using System;

// Token: 0x02000029 RID: 41
public abstract class SimpleMusic : SimpleAudio
{
	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060000A1 RID: 161 RVA: 0x00003823 File Offset: 0x00001A23
	protected override float StartVolume
	{
		get
		{
			return SimpleAudioData<GlobalMusicData>.StaticInstance.Volume;
		}
	}
}
