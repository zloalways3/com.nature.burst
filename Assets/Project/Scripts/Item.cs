using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class Item : Initializable<ItemConfig>
{
	// Token: 0x14000001 RID: 1
	// (add) Token: 0x06000012 RID: 18 RVA: 0x000021C8 File Offset: 0x000003C8
	// (remove) Token: 0x06000013 RID: 19 RVA: 0x000021FC File Offset: 0x000003FC
	public static event Action<Item> Selected;

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000014 RID: 20 RVA: 0x0000222F File Offset: 0x0000042F
	// (set) Token: 0x06000015 RID: 21 RVA: 0x00002237 File Offset: 0x00000437
	public Vector2Int Position { get; private set; }

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000016 RID: 22 RVA: 0x00002240 File Offset: 0x00000440
	public int Id
	{
		get
		{
			return this.@ӕ;
		}
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002248 File Offset: 0x00000448
	protected override void Initialize(ItemConfig config)
	{
		this.@ӕ = config.Id;
		this.Position = config.Position;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002264 File Offset: 0x00000464
	public void Select()
	{
        Item.Selected?.Invoke(this);
    }

	// Token: 0x06000019 RID: 25 RVA: 0x00002279 File Offset: 0x00000479
	public void UpdatePosition(Vector2Int position)
	{
		this.Position = position;
	}

	// Token: 0x04000007 RID: 7
	private int @ӕ;
}
