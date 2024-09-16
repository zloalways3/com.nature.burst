using System;
using UnityEngine;

// Token: 0x02000021 RID: 33
public class LoseView : MonoBehaviour
{
	// Token: 0x0600007A RID: 122 RVA: 0x000032CB File Offset: 0x000014CB
	private void Awake()
	{
		this.@ӓ.Expired += new Action(this.@ӗ);
	}

	// Token: 0x0600007B RID: 123 RVA: 0x000032E6 File Offset: 0x000014E6
	private void @ӗ()
	{
		this.@ӕ.SetActive(true);
	}

	// Token: 0x0600007C RID: 124 RVA: 0x000032F6 File Offset: 0x000014F6
	private void OnDestroy()
	{
		this.@ӓ.Expired -= new Action(this.@ӗ);
	}

	// Token: 0x04000041 RID: 65
	[SerializeField]
	private Timer @ӓ;

	// Token: 0x04000042 RID: 66
	[SerializeField]
	private AvaibleMatches @Ӕ;

	// Token: 0x04000043 RID: 67
	[SerializeField]
	private GameObject @ӕ;
}
