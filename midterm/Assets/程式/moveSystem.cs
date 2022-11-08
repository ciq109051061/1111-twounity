using UnityEngine;

namespace Blythe
{

    public class moveSystem : MonoBehaviour
    {
        [SerializeField, Header("²¾°Ê³t«×"), Range(-10, 0)]
        private float speed = -3.5f;
        private void Update()
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);

        }
    }
}
