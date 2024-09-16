using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Token: 0x02000016 RID: 22
public class Timer : MonoBehaviour
{
	// Token: 0x14000006 RID: 6
	// (add) Token: 0x06000050 RID: 80 RVA: 0x00002DF0 File Offset: 0x00000FF0
	// (remove) Token: 0x06000051 RID: 81 RVA: 0x00002E28 File Offset: 0x00001028
	public event Action<int> Updated;

	// Token: 0x14000007 RID: 7
	// (add) Token: 0x06000052 RID: 82 RVA: 0x00002E60 File Offset: 0x00001060
	// (remove) Token: 0x06000053 RID: 83 RVA: 0x00002E98 File Offset: 0x00001098
	public event Action Expired;

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000054 RID: 84 RVA: 0x00002ECD File Offset: 0x000010CD
	public int Seconds
	{
		get
		{
			return this.@Ӗ;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000055 RID: 85 RVA: 0x00002ED5 File Offset: 0x000010D5
	public int SecondsLeft
	{
		get
		{
			return this.@ӗ;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000056 RID: 86 RVA: 0x00002EDD File Offset: 0x000010DD
	private bool @ә
	{
		get
		{
			return this.@ӗ > 0;
		}
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002EE8 File Offset: 0x000010E8
	public void Pause()
	{
		this.@Ә = true;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002EF2 File Offset: 0x000010F2
	public void Resume()
	{
		this.@Ә = false;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002EFC File Offset: 0x000010FC
	private void Start()
	{
		this.@ӗ = this.@Ӗ;
		base.StartCoroutine(this.@Ӝ());
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002F18 File Offset: 0x00001118
	private IEnumerator @Ӝ()
	{
		WaitForSecondsRealtime wait = new WaitForSecondsRealtime(1f);
		WaitWhile pauseWait = new WaitWhile(new Func<bool>(this.@ӝ));
		while (this.@ә)
		{
			this.@ӗ--;

            Updated?.Invoke(this.@ӗ);

            yield return wait;
			yield return pauseWait;
		}

        Expired?.Invoke();

        yield break;
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002F38 File Offset: 0x00001138
	[CompilerGenerated]
	private bool @ӝ()
	{
		return this.@Ә;
	}

	// Token: 0x0400002D RID: 45
	[SerializeField]
	private int @Ӗ = 15;

	// Token: 0x0400002E RID: 46
	private int @ӗ;

	// Token: 0x0400002F RID: 47
	private bool @Ә;
}
