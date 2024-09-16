using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000031 RID: 49
public static class SceneLoader
{
	// Token: 0x1400000A RID: 10
	// (add) Token: 0x060000BA RID: 186 RVA: 0x000039B8 File Offset: 0x00001BB8
	// (remove) Token: 0x060000BB RID: 187 RVA: 0x000039EC File Offset: 0x00001BEC
	public static event Action<float> ProgressUpdated;

	// Token: 0x1400000B RID: 11
	// (add) Token: 0x060000BC RID: 188 RVA: 0x00003A20 File Offset: 0x00001C20
	// (remove) Token: 0x060000BD RID: 189 RVA: 0x00003A54 File Offset: 0x00001C54
	public static event Action Loaded;

	// Token: 0x060000BE RID: 190 RVA: 0x00003A88 File Offset: 0x00001C88
	public static void RestartScene()
	{
		string name = SceneManager.GetActiveScene().name;
		SceneLoader.Load(name);
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00003AAC File Offset: 0x00001CAC
	[DebuggerStepThrough]
	public async static void Load(string name)
	{
		var loading = SceneManager.LoadSceneAsync(name);

		while (!loading.isDone)
		{
			ProgressUpdated?.Invoke(loading.progress);
            await Task.Delay(Mathf.RoundToInt(@Ӕ * @ӓ));
		}

		Loaded?.Invoke();
    }

	// Token: 0x0400005E RID: 94
	private const int @ӓ = 1000;

	// Token: 0x0400005F RID: 95
	private const float @Ӕ = 0.1f;
}
