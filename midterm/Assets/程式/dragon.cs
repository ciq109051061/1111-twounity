using UnityEngine;

namespace Blythe
{
    public class dragon : MonoBehaviour
    {
        
        [SerializeField]
        private Animator dragonAnimator;

        [SerializeField]
        private SpriteRenderer dragonSpriteRenderer;

        [Header("¹Ï¤ù")]
        [SerializeField]
        private Sprite strike_03;

        [SerializeField]
        private Sprite idle_01;


        private void Start()
        {
            dragonAnimator = GetComponent<Animator>();
            dragonSpriteRenderer = GetComponent<SpriteRenderer>();

        }
        private void FixedUpdate()
        {
        
            if (Input.GetButton("Horizontal"))
            {
                dragonSpriteRenderer.sprite = strike_03;
            }
            else
            {
                dragonSpriteRenderer.sprite = idle_01;
            }
        }
    }
    
}