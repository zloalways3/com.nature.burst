using System;
using UnityEngine;

// Token: 0x0200000A RID: 10
public readonly struct ItemConfig
{
	// Token: 0x0600001B RID: 27 RVA: 0x0000228D File Offset: 0x0000048D
	public ItemConfig(int id, Vector2Int position)
	{
		this.Id = id;
		this.Position = position;
	}

	// Token: 0x04000008 RID: 8
	public readonly int Id;

	// Token: 0x04000009 RID: 9
	public readonly Vector2Int Position;
}
