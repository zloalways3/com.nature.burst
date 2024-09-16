using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000033 RID: 51
[RequireComponent(typeof(Slider))]
public abstract class Bar : MonoBehaviour
{
	// Token: 0x1700001A RID: 26
	// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003C60 File Offset: 0x00001E60
	protected Slider Slider
	{
		get
		{
			return this.@ӓ;
		}
	}

	// Token: 0x1400000C RID: 12
	// (add) Token: 0x060000C4 RID: 196 RVA: 0x0000395A File Offset: 0x00001B5A
	// (remove) Token: 0x060000C5 RID: 197 RVA: 0x0000395A File Offset: 0x00001B5A
	protected virtual event Action<float> RefreshEvent
	{
		add
		{
		}
		remove
		{
		}
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x0000395A File Offset: 0x00001B5A
	protected virtual void HandleInitialized()
	{
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00003C68 File Offset: 0x00001E68
	private void Start()
	{
		this.@ӓ = base.GetComponent<Slider>();
		this.@ӓ.interactable = false;
		this.RefreshEvent += new Action<float>(this.Refresh);
		this.HandleInitialized();
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00003C9E File Offset: 0x00001E9E
	protected void Refresh(float value)
	{
		this.@ӓ.value = value;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00003CAE File Offset: 0x00001EAE
	private void OnDestroy()
	{
		this.RefreshEvent -= new Action<float>(this.Refresh);
	}

	// Token: 0x0400006A RID: 106
	private Slider @ӓ;
}
