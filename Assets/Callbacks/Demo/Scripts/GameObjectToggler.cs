using UnityEngine;
namespace JacobHomanics.Core.Callbacks.Examples
{

    public class GameObjectToggler : MonoBehaviour
    {
        public void Toggle()
        {
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}
