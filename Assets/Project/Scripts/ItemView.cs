using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000019 RID: 25
[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
[RequireComponent(typeof(Item))]
public class ItemView : Initializable<ItemSpriteList>
{
	// Token: 0x06000064 RID: 100 RVA: 0x00003078 File Offset: 0x00001278
	protected override void Initialize(ItemSpriteList spriteList)
	{
		this.@ӓ = base.GetComponent<Image>();
		this.@Ӕ = base.GetComponent<Item>();
		this.@ӕ = base.GetComponent<Button>();
		this.@ӓ.sprite = spriteList.GetByIndex(this.@Ӕ.Id);
		this.@ӕ.onClick.AddListener(new UnityAction(this.@Ӗ));
	}

	// Token: 0x06000065 RID: 101 RVA: 0x000030E4 File Offset: 0x000012E4
	private void @Ӗ()
	{
		this.@Ӕ.Select();
	}

	// Token: 0x04000035 RID: 53
	private Image @ӓ;

	// Token: 0x04000036 RID: 54
	private Item @Ӕ;

	// Token: 0x04000037 RID: 55
	private Button @ӕ;
}
