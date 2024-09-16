using System;
using System.Linq;
using UnityEngine;

// Token: 0x02000004 RID: 4
public class AvaibleMatches : MonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000003 RID: 3 RVA: 0x00002059 File Offset: 0x00000259
	public bool NoHasMatches
	{
		get
		{
			return this.@ӕ == 0;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000004 RID: 4 RVA: 0x00002064 File Offset: 0x00000264
	private int @ӕ
	{
		get
		{
			return this.@ӗ();
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000206C File Offset: 0x0000026C
	private int @ӗ()
	{
		int count = 0;
		int lastCount = 0;
		for (int i = 0; i < this.@ӓ.Count; i++)
		{
			Item byIndex = this.@ӓ.GetByIndex(i);
			if (byIndex != null)
			{
				if (byIndex.gameObject.activeInHierarchy)
				{
					int newCount = Enumerable.Count<Item>(this.@Ӕ.FindAllMatches(byIndex));
					if (newCount - 1 > lastCount)
					{
						lastCount = newCount;
                        count += newCount;
					}
				}
			}
		}
		return count;
	}

	// Token: 0x04000001 RID: 1
	[SerializeField]
	private ItemList @ӓ;

	// Token: 0x04000002 RID: 2
	[SerializeField]
	private MatchFinder @Ӕ;
}
