using UnityEngine;

// Token: 0x02000030 RID: 48
public class AutoSceneLoadRequest : MonoBehaviour
{
	// Token: 0x060000B8 RID: 184 RVA: 0x000039A6 File Offset: 0x00001BA6
	private void Start()
	{
		SceneLoader.Load(this.@ӓ);
	}

	// Token: 0x0400005D RID: 93
	[SerializeField]
	private string @ӓ;
}
