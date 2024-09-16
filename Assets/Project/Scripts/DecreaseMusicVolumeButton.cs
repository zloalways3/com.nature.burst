using System;

// Token: 0x02000037 RID: 55
public class DecreaseMusicVolumeButton : ButtonListener
{
	// Token: 0x060000D4 RID: 212 RVA: 0x00003D70 File Offset: 0x00001F70
	protected override void Handle()
	{
		GlobalMusicData staticInstance = SimpleAudioData<GlobalMusicData>.StaticInstance;
		float volume = staticInstance.Volume - 0.125f;
		staticInstance.ChangeVolume(volume);
	}

	// Token: 0x0400006E RID: 110
	private const float @ӓ = 0.125f;
}
