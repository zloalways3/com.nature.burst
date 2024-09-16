using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Token: 0x0200000D RID: 13
public class ItemGravity : Initializable<CellList>
{
	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000022 RID: 34 RVA: 0x000023A4 File Offset: 0x000005A4
	// (remove) Token: 0x06000023 RID: 35 RVA: 0x000023DC File Offset: 0x000005DC
	public event Action Falled;

	// Token: 0x06000024 RID: 36 RVA: 0x00002411 File Offset: 0x00000611
	protected override void Initialize(CellList cellList)
	{
		this.@Ӗ = cellList;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x0000241B File Offset: 0x0000061B
	private void Awake()
	{
		this.@Ӕ.Found += new Action<IEnumerable<Item>>(this.@Ә);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002438 File Offset: 0x00000638
	private void @Ә(IEnumerable<Item> @ӓ)
	{
		IEnumerable<Item> above = this.@ә(@ӓ);
		if (Enumerable.Count<Item>(above) != 0)
		{
			int minItem = Enumerable.Min<Item>(@ӓ, (Item item) => item.Position.x);
			int maxItem = Enumerable.Max<Item>(@ӓ, (Item item) => item.Position.x);
			foreach (Item item3 in above)
			{
				int x = item3.Position.x;
				int y = item3.Position.y;
				int min = Enumerable.Min<Item>(Enumerable.Where<Item>(@ӓ, (Item item) => item.Position.x == x), (Item item) => item.Position.y);
				int max = Enumerable.Max<Item>(above, (Item item) => item.Position.y);
				IEnumerable<Item> biggerThenY = Enumerable.Where<Item>(@ӓ, (Item newItem) => newItem.Position.x == x && newItem.Position.y > y);
				int distance = 0;
				foreach (Item item2 in biggerThenY)
				{
					if (this.@ӕ.GetByPosition(item2.Position) != null)
					{
						distance++;
					}
				}
				IEnumerable<Item> xMatch = Enumerable.Where<Item>(above, (Item item) => item.Position.x == x);
				Vector2Int position = item3.Position;
				Vector2Int position2;
				position2 = new Vector2Int(x, item3.Position.y + distance);
				Cell byPosition = this.@Ӗ.GetByPosition(position2);
				item3.transform.SetParent(byPosition.transform, false);
				item3.UpdatePosition(position2);
			}

			Falled?.Invoke();
        }
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002698 File Offset: 0x00000898
	private IEnumerable<Item> @ә(IEnumerable<Item> @ӓ)
	{
		HashSet<Item> hashSet = new HashSet<Item>();
		Vector2Int down = Vector2Int.down;
		foreach (Item item in @ӓ)
		{
			Item item2 = item;
			while (item2 != null)
			{
				Vector2Int position = item2.Position;
				item2 = this.@ӕ.GetByPosition(position + down);
				if (item2 != null)
				{
					if (!Enumerable.Contains<Item>(@ӓ, item2))
					{
						hashSet.Add(item2);
					}
				}
			}
		}
		return hashSet;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002750 File Offset: 0x00000950
	private void OnDestroy()
	{
		this.@Ӕ.Found -= new Action<IEnumerable<Item>>(this.@Ә);
	}

	// Token: 0x0400000E RID: 14
	[SerializeField]
	private MatchFinder @Ӕ;

	// Token: 0x0400000F RID: 15
	[SerializeField]
	private ItemList @ӕ;

	// Token: 0x04000010 RID: 16
	private CellList @Ӗ;
}
