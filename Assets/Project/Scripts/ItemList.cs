using System;
using System.Linq;
using UnityEngine;

// Token: 0x02000010 RID: 16
public class ItemList : InitializableList<Item>
{
	// Token: 0x06000034 RID: 52 RVA: 0x00002874 File Offset: 0x00000A74
	public Item GetByPosition(Vector2Int position)
	{
		return Enumerable.FirstOrDefault<Item>(base.Elements, (Item item) => item.Position == position);
	}
}
