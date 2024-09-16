using System;
using UnityEngine;

// Token: 0x0200002C RID: 44
public abstract class Initializable : MonoBehaviour
{
	// Token: 0x060000A7 RID: 167 RVA: 0x000038A0 File Offset: 0x00001AA0
	public bool TryInitialize()
	{
		bool result;
		if (@ӓ)
		{
			result = false;
		}
		else
		{
			this.Initialize();
			this.@ӓ = true;
			result = true;
		}
		return result;
	}

	// Token: 0x060000A8 RID: 168
	protected abstract void Initialize();

	// Token: 0x04000059 RID: 89
	private bool @ӓ;
}
