using System;
using UnityEngine;

// Token: 0x0200003B RID: 59
public class ExitButton : ButtonListener
{
	// Token: 0x060000E0 RID: 224 RVA: 0x00003E56 File Offset: 0x00002056
	protected override void Handle()
	{
		Application.Quit();
	}
}
