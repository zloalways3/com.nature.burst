using System;
using UnityEngine;

// Token: 0x0200001E RID: 30
public class TimerView : Bar
{
	// Token: 0x14000008 RID: 8
	// (add) Token: 0x06000072 RID: 114 RVA: 0x00003208 File Offset: 0x00001408
	// (remove) Token: 0x06000073 RID: 115 RVA: 0x0000323C File Offset: 0x0000143C
	protected override event Action<float> RefreshEvent
	{
		add
		{
			this._timer.Updated += delegate(int seconds)
			{
				value?.Invoke((float)seconds);
			};
		}
		remove
		{
			this._timer.Updated -= delegate(int seconds)
			{
				value?.Invoke((float)seconds);
			};
		}
	}

	// Token: 0x06000074 RID: 116 RVA: 0x0000326F File Offset: 0x0000146F
	protected override void HandleInitialized()
	{
		base.Slider.maxValue = (float)this._timer.Seconds;
		base.Slider.value = (float)this._timer.Seconds;
	}

	// Token: 0x0400003E RID: 62
	[SerializeField]
	private Timer _timer;
}
