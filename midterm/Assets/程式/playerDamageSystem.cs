using UnityEngine;

namespace Blythe
{

    public class playerDamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�|�y���ˮ`���ؼ�")]
        private string nameTarget;
        [SerializeField, Header("�z���w�m��")]
        private GameObject prefabExplosion;

        private Animator myAnimator;

        private void Start()
        {
            myAnimator = GetComponent<Animator>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            // print("�I��" + collision.gameObject);
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);               
                Destroy(gameObject);
            }
        }
        
    }
}
