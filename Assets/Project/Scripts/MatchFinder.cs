using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Token: 0x02000014 RID: 20
public class MatchFinder : MonoBehaviour
{
	// Token: 0x14000004 RID: 4
	// (add) Token: 0x06000041 RID: 65 RVA: 0x00002AC0 File Offset: 0x00000CC0
	// (remove) Token: 0x06000042 RID: 66 RVA: 0x00002AF8 File Offset: 0x00000CF8
	public event Action<IEnumerable<Item>> Found;

	// Token: 0x06000043 RID: 67 RVA: 0x00002B2D File Offset: 0x00000D2D
	private void Awake()
	{
		Item.Selected += new Action<Item>(this.@ӗ);
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002B44 File Offset: 0x00000D44
	private void @ӗ(Item @ӓ)
	{
		IEnumerable<Item> enumerable = this.FindAllMatches(@ӓ);
		if (Enumerable.Count<Item>(enumerable) > 1)
		{
			Found?.Invoke(enumerable);
		}
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002B80 File Offset: 0x00000D80
	public IEnumerable<Item> FindAllMatches(Item item)
	{
		HashSet<Item> hashSet = new HashSet<Item>();
		hashSet.UnionWith(this.@Ә(item));
		HashSet<Item> hashSet2 = hashSet;
		for (int i = 0; i < hashSet.Count; i++)
		{
			hashSet2.UnionWith(this.@Ә(Enumerable.ElementAt<Item>(hashSet, i)));
		}
		return hashSet2;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002BD8 File Offset: 0x00000DD8
	private IEnumerable<Item> @Ә(Item @ӓ)
	{
		Vector2Int position = @ӓ.Position;
		int id = @ӓ.Id;
		HashSet<Item> hashSet = new HashSet<Item>();
		foreach (Vector2Int vector2Int in this.@ӕ)
		{
			Item item = @ӓ;
			int num = 0;
			while (item != null)
			{
				if (item.Id != id)
				{
					break;
				}
				hashSet.Add(item);
				num++;
				item = this.@Ӕ.GetByPosition(position + vector2Int * num);
			}
		}
		return hashSet;
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002C98 File Offset: 0x00000E98
	private void OnDestroy()
	{
		Item.Selected -= new Action<Item>(this.@ӗ);
	}

	// Token: 0x04000024 RID: 36
	[SerializeField]
	private ItemList @Ӕ;

	// Token: 0x04000025 RID: 37
	private readonly IEnumerable<Vector2Int> @ӕ = new List<Vector2Int>
    {
        Vector2Int.left,
		Vector2Int.right,
		Vector2Int.down,
		Vector2Int.up
    };
}
