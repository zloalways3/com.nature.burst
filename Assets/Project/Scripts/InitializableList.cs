using System;
using System.Collections.Generic;

// Token: 0x0200002E RID: 46
public abstract class InitializableList<T> : Initializable<IEnumerable<T>>
{
	// Token: 0x17000016 RID: 22
	// (get) Token: 0x060000AD RID: 173 RVA: 0x00003900 File Offset: 0x00001B00
	public int Count
	{
		get
		{
			return this._elements.Count;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060000AE RID: 174 RVA: 0x0000390D File Offset: 0x00001B0D
	protected IEnumerable<T> Elements
	{
		get
		{
			return this._elements;
		}
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00003915 File Offset: 0x00001B15
	public void Add(T element)
	{
		this._elements.Add(element);
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00003924 File Offset: 0x00001B24
	public T GetByIndex(int index)
	{
		return this._elements[index];
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00003942 File Offset: 0x00001B42
	protected override void Initialize(IEnumerable<T> elements)
	{
		this._elements.AddRange(elements);
		this.HandleInitialized(elements);
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x0000395A File Offset: 0x00001B5A
	protected virtual void HandleInitialized(IEnumerable<T> elements)
	{
	}

	// Token: 0x0400005B RID: 91
	private readonly List<T> _elements = new List<T>();
}
