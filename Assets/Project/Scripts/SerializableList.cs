using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200002F RID: 47
public abstract class SerializableList<T> : MonoBehaviour
{
	// Token: 0x17000018 RID: 24
	// (get) Token: 0x060000B4 RID: 180 RVA: 0x00003971 File Offset: 0x00001B71
	public int Count
	{
		get
		{
			return this._elements.Count;
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000397E File Offset: 0x00001B7E
	protected IEnumerable<T> Elements
	{
		get
		{
			return this._elements;
		}
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00003988 File Offset: 0x00001B88
	public T GetByIndex(int index)
	{
		return this._elements[index];
	}

	// Token: 0x0400005C RID: 92
	[SerializeField]
	private List<T> _elements;
}
