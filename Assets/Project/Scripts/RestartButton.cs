using System;

// Token: 0x0200003C RID: 60
public class RestartButton : ButtonListener
{
	// Token: 0x060000E2 RID: 226 RVA: 0x00003E5F File Offset: 0x0000205F
	protected override void Handle()
	{
		SceneLoader.RestartScene();
	}
}
