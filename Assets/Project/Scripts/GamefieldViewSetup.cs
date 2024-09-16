using System;
using UnityEngine;

// Token: 0x0200001C RID: 28
public class GamefieldViewSetup : MonoBehaviour
{
	// Token: 0x0600006A RID: 106 RVA: 0x00003122 File Offset: 0x00001322
	private void Awake()
	{
		this.@ӓ.Initialized += new Action(this.@ӗ);
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00003140 File Offset: 0x00001340
	private void @ӗ()
	{
		ItemList itemList = this.@Ӕ;
		for (int i = 0; i < itemList.Count; i++)
		{
			Item byIndex = itemList.GetByIndex(i);
			ItemView view;
			if (byIndex.TryGetComponent<ItemView>(out view))
			{
				this.@ӕ.InitializeView(view);
			}
		}
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00003196 File Offset: 0x00001396
	private void OnDestroy()
	{
		this.@ӓ.Initialized -= new Action(this.@ӗ);
	}

	// Token: 0x0400003A RID: 58
	[SerializeField]
	private GamefieldSetup @ӓ;

	// Token: 0x0400003B RID: 59
	[SerializeField]
	private ItemList @Ӕ;

	// Token: 0x0400003C RID: 60
	[SerializeField]
	private ItemViewSetup @ӕ;
}
