using System;

// Token: 0x02000038 RID: 56
public class IncreaseMusicVolumeButton : ButtonListener
{
	// Token: 0x060000D6 RID: 214 RVA: 0x00003D9C File Offset: 0x00001F9C
	protected override void Handle()
	{
		GlobalMusicData staticInstance = SimpleAudioData<GlobalMusicData>.StaticInstance;
		float volume = staticInstance.Volume + 0.125f;
		staticInstance.ChangeVolume(volume);
	}

	// Token: 0x0400006F RID: 111
	private const float @ӓ = 0.125f;
}
