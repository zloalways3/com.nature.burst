using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

// Token: 0x02000013 RID: 19
public class GamefieldSetup : MonoBehaviour
{
    // Token: 0x14000003 RID: 3
    // (add) Token: 0x0600003A RID: 58 RVA: 0x0000292C File Offset: 0x00000B2C
    // (remove) Token: 0x0600003B RID: 59 RVA: 0x00002964 File Offset: 0x00000B64
	public event Action Initialized;

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600003C RID: 60 RVA: 0x00002999 File Offset: 0x00000B99
	// (set) Token: 0x0600003D RID: 61 RVA: 0x000029A1 File Offset: 0x00000BA1
	public CellList SelectedCellList { get; private set; }

	// Token: 0x0600003E RID: 62 RVA: 0x000029AC File Offset: 0x00000BAC
	private void Start()
	{
		this.SelectedCellList = this.@ӝ(SelectedDifficulty.Difficulty);
		this.SelectedCellList.gameObject.SetActive(true);
		this.@Ӕ.Spawn(this.SelectedCellList);
		int num = 0;
		for (int i = 0; i < this.SelectedCellList.SideLenght; i++)
		{
			for (int j = 0; j < this.SelectedCellList.SideLenght; j++)
			{
				Cell byIndex = this.SelectedCellList.GetByIndex(num);
				Vector2Int position;
				position = new Vector2Int(j, i);
				this.@ӕ.TryInitialize(byIndex, position);
				num++;
			}
		}
		this.@Ӗ.TryInitialize(this.SelectedCellList);

        Initialized?.Invoke();
    }

	// Token: 0x0600003F RID: 63 RVA: 0x00002A7C File Offset: 0x00000C7C
	private CellList @ӝ(Difficulty @ӓ)
	{
		CellList result;
		switch (@ӓ)
		{
		case Difficulty.Easy:
			result = this.@ӗ;
			break;
		case Difficulty.Middle:
			result = this.@Ә;
			break;
		case Difficulty.Hard:
			result = this.@ә;
			break;
		default:
			throw new ArgumentException();
		}
		return result;
	}

	// Token: 0x0400001C RID: 28
	[SerializeField]
	private ItemFabric @Ӕ;

	// Token: 0x0400001D RID: 29
	[SerializeField]
	private CellSetup @ӕ;

	// Token: 0x0400001E RID: 30
	[SerializeField]
	private ItemGravity @Ӗ;

	// Token: 0x0400001F RID: 31
	[SerializeField]
	private CellList @ӗ;

	// Token: 0x04000020 RID: 32
	[SerializeField]
	private CellList @Ә;

	// Token: 0x04000021 RID: 33
	[SerializeField]
	private CellList @ә;
}
