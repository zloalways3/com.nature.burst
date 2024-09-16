using System;
using UnityEngine;
using Object = UnityEngine.Object;

// Token: 0x0200003A RID: 58
public class NextDifficultyButton : ButtonListener
{
	// Token: 0x060000DD RID: 221 RVA: 0x00003E08 File Offset: 0x00002008
	protected override void HandleSubscribed()
	{
		if (SelectedDifficulty.Difficulty == Difficulty.Hard)
		{
			Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00003E34 File Offset: 0x00002034
	protected override void Handle()
	{
		if (SelectedDifficulty.TryNext())
		{
			SceneLoader.RestartScene();
		}
	}
}
