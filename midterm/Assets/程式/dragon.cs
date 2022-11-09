using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 龍
    /// </summary>
    public class dragon : MonoBehaviour
    {
        #region 宣告與取得

        [SerializeField]
        private Animator dragonAnimator;

        [SerializeField,Header("圖片渲染元件")]
        private SpriteRenderer dragonSpriteRenderer;

       
        private void Start()
        {
            dragonAnimator = GetComponent<Animator>();
            dragonSpriteRenderer = GetComponent<SpriteRenderer>();

        }

#endregion

        private void FixedUpdate()
        {
            #region SpriteRenderer方向

            if (Input.GetKey(KeyCode.D))
            {
                dragonSpriteRenderer.flipX = false;
            }

            if (Input.GetKey(KeyCode.A))
            {
                dragonSpriteRenderer.flipX = true;

            }

            #endregion

        }
    }
    
}