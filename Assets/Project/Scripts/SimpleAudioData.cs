using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Object = UnityEngine.Object;

// Token: 0x02000026 RID: 38
public abstract class SimpleAudioData<T> : MonoBehaviour where T : SimpleAudioData<T>
{
	// Token: 0x14000009 RID: 9
	// (add) Token: 0x06000092 RID: 146 RVA: 0x000035F8 File Offset: 0x000017F8
	// (remove) Token: 0x06000093 RID: 147 RVA: 0x00003630 File Offset: 0x00001830
	
	public event Action<float> VolumeChanged;

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000094 RID: 148 RVA: 0x00003665 File Offset: 0x00001865
	// (set) Token: 0x06000095 RID: 149 RVA: 0x0000366C File Offset: 0x0000186C
	public static T StaticInstance { get; private set; }

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000096 RID: 150 RVA: 0x00003674 File Offset: 0x00001874
	public float Volume
	{
		get
		{
			return this._volume;
		}
	}

	// Token: 0x06000097 RID: 151
	protected abstract IReadOnlyCollection<SimpleAudio> GetAudios();

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000098 RID: 152
	protected abstract string SaveKey { get; }

	// Token: 0x06000099 RID: 153 RVA: 0x0000367C File Offset: 0x0000187C
	public void ChangeVolume(float volume)
	{
		volume = Mathf.Clamp01(volume);
		IReadOnlyCollection<SimpleAudio> audios = this.GetAudios();
		foreach (SimpleAudio simpleAudio in audios)
		{
			simpleAudio.ChangeVolume(volume);
		}
		this._volume = volume;
		PlayerPrefs.SetFloat(this.SaveKey, volume);

		VolumeChanged?.Invoke(this._volume);

    }

	// Token: 0x0600009A RID: 154 RVA: 0x00003708 File Offset: 0x00001908
	private void InitializeAudio()
	{
		IReadOnlyCollection<SimpleAudio> audios = this.GetAudios();
		foreach (SimpleAudio simpleAudio in audios)
		{
			simpleAudio.TryInitialize();
		}
	}

	// Token: 0x0600009B RID: 155 RVA: 0x0000375C File Offset: 0x0000195C
	private void Awake()
	{
		T[] array = Object.FindObjectsOfType<T>();
		foreach (T t in array)
		{
			if (t == this)
			{
				SimpleAudioData<T>.StaticInstance = t;
			}
			else
			{
				Object.Destroy(t.gameObject);
			}
		}
		Object.DontDestroyOnLoad(base.gameObject);
		this.InitializeAudio();
		float @float = PlayerPrefs.GetFloat(this.SaveKey);
		this.ChangeVolume(@float);
	}

	// Token: 0x04000051 RID: 81
	private float _volume;
}
