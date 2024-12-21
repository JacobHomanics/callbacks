namespace JacobHomanics.Core.Callbacks
{
	public class StartCallback : MonoBehaviourCallback
	{
		private void Start()
		{
			Callback?.Invoke(this);
		}
	}
}
