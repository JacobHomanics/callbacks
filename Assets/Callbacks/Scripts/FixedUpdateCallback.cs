namespace JacobHomanics.Core.Callbacks
{
	public class FixedUpdateCallback : MonoBehaviourCallback
	{
		private void FixedUpdate()
		{
			Callback?.Invoke(this);
		}
	}
}
