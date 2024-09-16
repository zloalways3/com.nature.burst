using System;
using UnityEngine;

// Token: 0x02000025 RID: 37
[DisallowMultipleComponent]
[RequireComponent(typeof(AudioSource))]
public abstract class SimpleAudio : Initializable
{
	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600008E RID: 142
	protected abstract float StartVolume { get; }

	// Token: 0x0600008F RID: 143 RVA: 0x000035BD File Offset: 0x000017BD
	public void ChangeVolume(float volume)
	{
		this._source.volume = volume;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x000035CD File Offset: 0x000017CD
	protected override void Initialize()
	{
		this._source = base.GetComponent<AudioSource>();
		this._source.volume = this.StartVolume;
	}

	// Token: 0x0400004F RID: 79
	private AudioSource _source;
}
