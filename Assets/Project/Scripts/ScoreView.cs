using System;
using UnityEngine;

// Token: 0x0200001D RID: 29
public class ScoreView : TextView<int>
{
	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600006E RID: 110 RVA: 0x000031B1 File Offset: 0x000013B1
	protected override StringMode StringMode
	{
		get
		{
			return StringMode.Default;
		}
	}

	// Token: 0x0600006F RID: 111 RVA: 0x000031B4 File Offset: 0x000013B4
	private void Awake()
	{
		base.RefreshView(this.@ӓ.Value);
		this.@ӓ.Added += new Action<int>(base.RefreshView);
	}

	// Token: 0x06000070 RID: 112 RVA: 0x000031E1 File Offset: 0x000013E1
	private void OnDestroy()
	{
		this.@ӓ.Added -= new Action<int>(base.RefreshView);
	}

	// Token: 0x0400003D RID: 61
	[SerializeField]
	private Score @ӓ;
}
