using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Token: 0x02000015 RID: 21
public class Score : MonoBehaviour
{
	// Token: 0x14000005 RID: 5
	// (add) Token: 0x06000049 RID: 73 RVA: 0x00002D00 File Offset: 0x00000F00
	// (remove) Token: 0x0600004A RID: 74 RVA: 0x00002D38 File Offset: 0x00000F38
	public event Action<int> Added;

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600004B RID: 75 RVA: 0x00002D6D File Offset: 0x00000F6D
	public int Value
	{
		get
		{
			return this.@Ӗ;
		}
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002D75 File Offset: 0x00000F75
	private void Awake()
	{
		this.@ӕ.Found += new Action<IEnumerable<Item>>(this.@Ә);
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002D90 File Offset: 0x00000F90
	private void @Ә(IEnumerable<Item> @ӓ)
	{
		this.@Ӗ += Enumerable.Count<Item>(@ӓ) * this.@Ӕ;

		Added?.Invoke(this.@Ӗ);

    }

	// Token: 0x0600004E RID: 78 RVA: 0x00002DC5 File Offset: 0x00000FC5
	private void OnDestroy()
	{
		this.@ӕ.Found -= new Action<IEnumerable<Item>>(this.@Ә);
	}

	// Token: 0x04000027 RID: 39
	[Min(1f)]
	[SerializeField]
	private int @Ӕ = 1;

	// Token: 0x04000028 RID: 40
	[SerializeField]
	private MatchFinder @ӕ;

	// Token: 0x04000029 RID: 41
	private int @Ӗ;
}
