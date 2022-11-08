using UnityEngine;

namespace Blythe
{

    public class playerDamageSystem : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField, Header("爆炸預置物")]
        private GameObject prefabExplosion;

        private Animator myAnimator;

        private void Start()
        {
            myAnimator = GetComponent<Animator>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            // print("碰撞" + collision.gameObject);
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);               
                Destroy(gameObject);
            }
        }
        
    }
}
