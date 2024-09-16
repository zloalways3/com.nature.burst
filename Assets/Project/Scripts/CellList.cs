using System;
using System.Linq;
using UnityEngine;

// Token: 0x02000006 RID: 6
public class CellList : SerializableList<Cell>
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600000B RID: 11 RVA: 0x00002130 File Offset: 0x00000330
	public int SideLenght
	{
		get
		{
			return Mathf.RoundToInt(Mathf.Sqrt((float)Enumerable.ToList<Cell>(base.Elements).Count));
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002150 File Offset: 0x00000350
	public Cell GetByPosition(Vector2Int position)
	{
		return Enumerable.FirstOrDefault<Cell>(base.Elements, (Cell cell) => cell.Position == position);
	}
}
