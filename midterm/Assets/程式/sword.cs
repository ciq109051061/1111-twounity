using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 劍氣方向
    /// </summary>
    public class sword : MonoBehaviour
    {
        #region SpriteRenderer宣告與取得

        [SerializeField]
        private SpriteRenderer swordSpriteRenderer;

        private void Start()
        {
            swordSpriteRenderer = GetComponent<SpriteRenderer>();
        }

        #endregion

        private void FixedUpdate()
        {
            #region SpriteRenderer方向

            if (Input.GetKey(KeyCode.D))
            {
                swordSpriteRenderer.flipX = false;
            }

            if (Input.GetKey(KeyCode.A))
            {
                swordSpriteRenderer.flipX = true;
            }

            #endregion
        }
    }
}
