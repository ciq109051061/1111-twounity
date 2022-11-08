using UnityEngine;

namespace Blythe
{

    public class bird : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer birdSpriteRenderer;

        private void Start()
        {
            birdSpriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            birdSpriteRenderer.flipX = true;
        }
    }
}
