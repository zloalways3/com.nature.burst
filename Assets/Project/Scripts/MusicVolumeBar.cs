using System;

// Token: 0x02000034 RID: 52
public class MusicVolumeBar : Bar
{
	// Token: 0x1400000D RID: 13
	// (add) Token: 0x060000CB RID: 203 RVA: 0x00003CC4 File Offset: 0x00001EC4
	// (remove) Token: 0x060000CC RID: 204 RVA: 0x00003CF8 File Offset: 0x00001EF8
	protected override event Action<float> RefreshEvent
	{
		add
		{
			this.@Ӕ.VolumeChanged += delegate(float volume)
			{
				value.Invoke(volume * 8f);
			};
		}
		remove
		{
			this.@Ӕ.VolumeChanged -= delegate(float volume)
			{
				value.Invoke(volume * 8f);
			};
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x060000CD RID: 205 RVA: 0x00003D2B File Offset: 0x00001F2B
	private GlobalMusicData @Ӕ
	{
		get
		{
			return SimpleAudioData<GlobalMusicData>.StaticInstance;
		}
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00003D32 File Offset: 0x00001F32
	protected override void HandleInitialized()
	{
		base.Slider.maxValue = 8;
		base.Slider.value = SimpleAudioData<GlobalMusicData>.StaticInstance.Volume * base.Slider.maxValue;
    }
}
