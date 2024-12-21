using UnityEngine;
using UnityEngine.Events;

namespace JacobHomanics.Core.Callbacks
{
    public class MonoBehaviourCallback : MonoBehaviour
    {
        public CallbackEvent Callback = new();
    }

    [System.Serializable]
    public class CallbackEvent : UnityEvent<MonoBehaviourCallback> { }
}