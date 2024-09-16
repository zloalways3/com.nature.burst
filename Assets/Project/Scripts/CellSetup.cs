using System;
using UnityEngine;

// Token: 0x02000008 RID: 8
public class CellSetup : MonoBehaviour
{
	// Token: 0x06000010 RID: 16 RVA: 0x000021AC File Offset: 0x000003AC
	public bool TryInitialize(Cell cell, Vector2Int position)
	{
		return cell.TryInitialize(position);
	}
}
