using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

// Token: 0x0200000B RID: 11
public class ItemDestroy : MonoBehaviour
{
	// Token: 0x0600001C RID: 28 RVA: 0x0000229E File Offset: 0x0000049E
	private void Awake()
	{
		this.@ӓ.Found += new Action<IEnumerable<Item>>(this.@ӕ);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x000022BC File Offset: 0x000004BC
	private void @ӕ(IEnumerable<Item> @ӓ)
	{
		foreach (Item item in @ӓ)
		{
			Object.Destroy(item.gameObject);
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002310 File Offset: 0x00000510
	private void OnDestroy()
	{
		this.@ӓ.Found -= new Action<IEnumerable<Item>>(this.@ӕ);
	}

	// Token: 0x0400000A RID: 10
	[SerializeField]
	private MatchFinder @ӓ;
}
