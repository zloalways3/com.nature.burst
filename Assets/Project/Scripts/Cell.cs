using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class Cell : Initializable<Vector2Int>
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000007 RID: 7 RVA: 0x0000210B File Offset: 0x0000030B
	// (set) Token: 0x06000008 RID: 8 RVA: 0x00002113 File Offset: 0x00000313
	public Vector2Int Position { get; private set; }

	// Token: 0x06000009 RID: 9 RVA: 0x0000211C File Offset: 0x0000031C
	protected override void Initialize(Vector2Int position)
	{
		this.Position = position;
	}

	// Token: 0x04000003 RID: 3
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Vector2Int @ӓ;
}
