namespace JacobHomanics.Core.Callbacks
{
    public class AwakeCallback : MonoBehaviourCallback
    {
        private void Awake()
        {
            Callback?.Invoke(this);
        }
    }
}