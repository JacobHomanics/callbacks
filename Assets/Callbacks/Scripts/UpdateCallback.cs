namespace JacobHomanics.Core.Callbacks
{
	public class UpdateCallback : MonoBehaviourCallback
	{
		private void Update()
		{
			Callback?.Invoke(this);
		}
	}
}