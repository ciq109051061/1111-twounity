using UnityEngine;

namespace Blythe
{
    public class dragon : MonoBehaviour
    {
        
        [SerializeField]
        private Animator dragonAnimator;

        [SerializeField]
        private SpriteRenderer dragonSpriteRenderer;

       


        private void Start()
        {
            dragonAnimator = GetComponent<Animator>();
            dragonSpriteRenderer = GetComponent<SpriteRenderer>();

        }
        private void FixedUpdate()
        {

            if (Input.GetKey(KeyCode.D))
            {
                dragonSpriteRenderer.flipX = false;
            }

            if (Input.GetKey(KeyCode.A))
            {
                dragonSpriteRenderer.flipX = true;

            }
        }
    }
    
}