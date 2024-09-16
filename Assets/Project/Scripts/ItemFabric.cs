using System;
using UnityEngine;
using Object = UnityEngine.Object;

// Token: 0x0200000C RID: 12
public class ItemFabric : MonoBehaviour
{
	// Token: 0x06000020 RID: 32 RVA: 0x0000232C File Offset: 0x0000052C
	public void Spawn(CellList cellList)
	{
		int sideLenght = cellList.SideLenght;
		for (int i = 0; i < sideLenght; i++)
		{
			for (int j = 0; j < sideLenght; j++)
			{
				Cell byIndex = cellList.GetByIndex(i + j * sideLenght);
				Transform transform = byIndex.transform;
				Item item = Object.Instantiate<Item>(this.@ӓ, transform);
				this.@Ӕ.InitializeItem(item, new Vector2Int(i, j));
			}
		}
	}

	// Token: 0x0400000B RID: 11
	[SerializeField]
	private Item @ӓ;

	// Token: 0x0400000C RID: 12
	[SerializeField]
	private ItemSetup @Ӕ;
}
