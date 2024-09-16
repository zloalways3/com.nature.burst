using System;

// Token: 0x0200003F RID: 63
public class DifficultyView : TextView<Difficulty>
{
	// Token: 0x1700001D RID: 29
	// (get) Token: 0x060000EA RID: 234 RVA: 0x00003EB1 File Offset: 0x000020B1
	protected override StringMode StringMode
	{
		get
		{
			return StringMode.ToUpper;
		}
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00003EB4 File Offset: 0x000020B4
	private void Start()
	{
		base.RefreshView(SelectedDifficulty.Difficulty);
	}
}
