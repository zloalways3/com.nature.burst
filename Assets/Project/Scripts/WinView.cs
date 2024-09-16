using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

// Token: 0x02000022 RID: 34
public class WinView : MonoBehaviour
{
	// Token: 0x0600007E RID: 126 RVA: 0x00003311 File Offset: 0x00001511
	private void Awake()
	{
		this.@ӓ.Falled += new Action(this.@Ә);
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0000332C File Offset: 0x0000152C
	[DebuggerStepThrough]
	private async void @Ә()
	{
		await Task.Delay(1000);

		if (!@Ӕ.NoHasMatches) return;

		@ӕ.SetActive(true);
		@Ӗ.Pause();
    }

	// Token: 0x06000080 RID: 128 RVA: 0x00003368 File Offset: 0x00001568
	private void OnDestroy()
	{
		this.@ӓ.Falled -= new Action(this.@Ә);
	}

	// Token: 0x04000044 RID: 68
	[SerializeField]
	private ItemGravity @ӓ;

	// Token: 0x04000045 RID: 69
	[SerializeField]
	private AvaibleMatches @Ӕ;

	// Token: 0x04000046 RID: 70
	[SerializeField]
	private GameObject @ӕ;

	// Token: 0x04000047 RID: 71
	[SerializeField]
	private Timer @Ӗ;
}
