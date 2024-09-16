using System;
using UnityEngine;

// Token: 0x0200002D RID: 45
public abstract class Initializable<T> : MonoBehaviour
{
	// Token: 0x060000AA RID: 170 RVA: 0x000038D0 File Offset: 0x00001AD0
	public bool TryInitialize(T args)
	{
		bool isInitialized = this._isInitialized;
		bool result;
		if (isInitialized)
		{
			result = false;
		}
		else
		{
			this.Initialize(args);
			this._isInitialized = true;
			result = true;
		}
		return result;
	}

	// Token: 0x060000AB RID: 171
	protected abstract void Initialize(T args);

	// Token: 0x0400005A RID: 90
	private bool _isInitialized;
}
