using System;
using UnityEngine;
using Random = UnityEngine.Random;

// Token: 0x02000012 RID: 18
public class ItemSetup : MonoBehaviour
{
	// Token: 0x06000038 RID: 56 RVA: 0x000028C8 File Offset: 0x00000AC8
	public bool InitializeItem(Item item, Vector2Int position)
	{
		bool result;
		if (item == null)
		{
			result = false;
		}
		else
		{
			item.transform.localPosition = Vector3.zero;
			int id = Random.Range(0, this.@Ӕ.Count);
			ItemConfig args = new ItemConfig(id, position);
			this.@ӓ.Add(item);
			result = item.TryInitialize(args);
		}
		return result;
	}

	// Token: 0x04000019 RID: 25
	[SerializeField]
	private ItemList @ӓ;

	// Token: 0x0400001A RID: 26
	[SerializeField]
	private ItemSpriteList @Ӕ;
}
