using System;
using TMPro;
using UnityEngine;

// Token: 0x02000041 RID: 65
public abstract class TextView<T> : MonoBehaviour
{
	// Token: 0x1700001E RID: 30
	// (get) Token: 0x060000ED RID: 237
	protected abstract StringMode StringMode { get; }

	// Token: 0x060000EE RID: 238 RVA: 0x00003ECC File Offset: 0x000020CC
	protected void RefreshView(T value)
	{
		string value2 = string.Format(this._format, value);
		this._textComponent.text = this.FormatToSelectedStringMode(value2);
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00003F00 File Offset: 0x00002100
	protected void RefreshView(T value1, T value2)
	{
		string value3 = string.Format(this._format, value1, value2);
		this._textComponent.text = this.FormatToSelectedStringMode(value3);
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00003F3C File Offset: 0x0000213C
	protected void RefreshView(T value1, T value2, T value3)
	{
		string value4 = string.Format(this._format, value1, value2, value3);
		this._textComponent.text = this.FormatToSelectedStringMode(value4);
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x00003F7C File Offset: 0x0000217C
	private string FormatToSelectedStringMode(string value)
	{
		string result;
		switch (this.StringMode)
		{
		case StringMode.Default:
			result = value;
			break;
		case StringMode.ToLower:
			result = value.ToLower();
			break;
		case StringMode.ToUpper:
			result = value.ToUpper();
			break;
		default:
			throw new ArgumentException();
		}
		return result;
	}

	// Token: 0x04000077 RID: 119
	[SerializeField]
	private TextMeshProUGUI _textComponent;

	// Token: 0x04000078 RID: 120
	[Multiline]
	[SerializeField]
	private string _format = "{0}";
}
