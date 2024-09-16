using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000039 RID: 57
[RequireComponent(typeof(Button))]
public abstract class ButtonListener : UIListener
{
	// Token: 0x1700001C RID: 28
	// (get) Token: 0x060000D8 RID: 216 RVA: 0x00003DC5 File Offset: 0x00001FC5
	// (set) Token: 0x060000D9 RID: 217 RVA: 0x00003DCD File Offset: 0x00001FCD
	protected Button Button => @ӓ;

    // Token: 0x060000DA RID: 218 RVA: 0x0000395A File Offset: 0x00001B5A
    protected virtual void HandleSubscribed()
	{
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00003DD6 File Offset: 0x00001FD6
	private void Start()
	{
		@ӓ = base.GetComponent<Button>();

        @ӓ.onClick.AddListener(new UnityAction(this.Handle));
		this.HandleSubscribed();
	}

	// Token: 0x04000070 RID: 112
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Button @ӓ;
}
