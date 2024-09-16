using System;
using UnityEngine;

// Token: 0x0200001B RID: 27
public class ItemViewSetup : MonoBehaviour
{
	// Token: 0x06000068 RID: 104 RVA: 0x00003105 File Offset: 0x00001305
	public void InitializeView(ItemView view)
	{
		view.TryInitialize(this.@ӓ);
		this.@Ӕ.Add(view);
	}

	// Token: 0x04000038 RID: 56
	[SerializeField]
	private ItemSpriteList @ӓ;

	// Token: 0x04000039 RID: 57
	[SerializeField]
	private ItemViewList @Ӕ;
}
