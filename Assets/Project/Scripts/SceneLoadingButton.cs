using System;
using UnityEngine;

// Token: 0x0200003D RID: 61
public class SceneLoadingButton : ButtonListener
{
	// Token: 0x060000E4 RID: 228 RVA: 0x00003E68 File Offset: 0x00002068
	protected override void Handle()
	{
		SceneLoader.Load(this._scene);
	}

	// Token: 0x04000071 RID: 113
	[SerializeField]
	private string _scene;
}
