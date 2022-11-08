using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// ¼C®ð¤è¦V
    /// </summary>
    public class sword : MonoBehaviour
    {
        [SerializeField]
        private SpriteRenderer swordSpriteRenderer;

        private void Start()
        {
            swordSpriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void FixedUpdate()
        {

            if (Input.GetKey(KeyCode.D))
            {
                swordSpriteRenderer.flipX = false;
            }

            if (Input.GetKey(KeyCode.A))
            {
                swordSpriteRenderer.flipX = true;

            }
        }
    }
}
