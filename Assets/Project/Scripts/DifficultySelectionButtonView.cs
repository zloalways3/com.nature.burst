using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Token: 0x02000024 RID: 36
[RequireComponent(typeof(EventTrigger))]
public class DifficultySelectionButtonView : ButtonListener
{
	// Token: 0x06000085 RID: 133 RVA: 0x00003480 File Offset: 0x00001680
	protected override void HandleSubscribed()
	{
		this.@ӗ();
		EventTrigger component = base.GetComponent<EventTrigger>();
		EventTrigger.Entry enter = new EventTrigger.Entry();
		EventTrigger.Entry down = new EventTrigger.Entry();
		EventTrigger.Entry exit = new EventTrigger.Entry();
		EventTrigger.Entry up = new EventTrigger.Entry();
		enter.eventID = EventTriggerType.PointerEnter;
		down.eventID = EventTriggerType.PointerDown;
		exit.eventID = EventTriggerType.PointerExit;
		up.eventID = EventTriggerType.PointerUp;
		enter.callback.AddListener(new UnityAction<BaseEventData>((_) => this.@Ӗ()));
		down.callback.AddListener(new UnityAction<BaseEventData>((_) => this.@Ӗ()));
		exit.callback.AddListener(new UnityAction<BaseEventData>((_) => this.@ӗ()));
		up.callback.AddListener(new UnityAction<BaseEventData>((_) => this.@ӗ()));
		component.triggers.Add(enter);
		component.triggers.Add(down);
		component.triggers.Add(exit);
		component.triggers.Add(up);
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00003568 File Offset: 0x00001768
	private void @Ӗ()
	{
		this.@Ӕ.SetActive(true);
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00003578 File Offset: 0x00001778
	private void @ӗ()
	{
		this.@Ӕ.SetActive(false);
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00003588 File Offset: 0x00001788
	protected override void Handle()
	{
		SelectedDifficulty.SetDifficulty(this.@ӕ);
		SceneLoader.Load("Gameplay");
	}

	// Token: 0x0400004C RID: 76
	private const string @ӓ = "Gameplay";

	// Token: 0x0400004D RID: 77
	[SerializeField]
	private GameObject @Ӕ;

	// Token: 0x0400004E RID: 78
	[SerializeField]
	private Difficulty @ӕ;
}
