using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x0200002B RID: 43
public static class SelectedDifficulty
{
	// Token: 0x17000015 RID: 21
	// (get) Token: 0x060000A3 RID: 163 RVA: 0x00003838 File Offset: 0x00001A38
	// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000383F File Offset: 0x00001A3F
	public static Difficulty Difficulty { get; private set; }

	// Token: 0x060000A5 RID: 165 RVA: 0x00003847 File Offset: 0x00001A47
	public static void SetDifficulty(Difficulty difficulty)
	{
		SelectedDifficulty.Difficulty = difficulty;
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00003854 File Offset: 0x00001A54
	public static bool TryNext()
	{
		bool result;
		if (SelectedDifficulty.Difficulty == Difficulty.Hard)
		{
			result = false;
		}
		else
		{
			Difficulty difficulty = SelectedDifficulty.Difficulty;
			Difficulty difficulty2;
			if (difficulty != Difficulty.Easy)
			{
				if (difficulty != Difficulty.Middle)
				{
					throw new ArgumentException();
				}
				difficulty2 = Difficulty.Hard;
			}
			else
			{
				difficulty2 = Difficulty.Middle;
			}
			SelectedDifficulty.Difficulty = difficulty2;
			result = true;
		}
		return result;
	}

	// Token: 0x04000058 RID: 88
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Difficulty @ӓ;
}
