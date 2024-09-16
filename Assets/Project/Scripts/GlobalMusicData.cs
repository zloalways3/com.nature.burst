using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000028 RID: 40
public class GlobalMusicData : SimpleAudioData<GlobalMusicData>
{
	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600009E RID: 158 RVA: 0x000037EB File Offset: 0x000019EB
	protected override string SaveKey
	{
		get
		{
			return "GlobalMusicDataVolume";
		}
	}

	// Token: 0x0600009F RID: 159 RVA: 0x000037F4 File Offset: 0x000019F4
	protected override IReadOnlyCollection<SimpleAudio> GetAudios()
	{
		List<SimpleAudio> list = new List<SimpleAudio>();
		list.Add(this.@ӓ);
		return list;
	}

	// Token: 0x04000053 RID: 83
	[SerializeField]
	private BackgroundLoop @ӓ;
}
