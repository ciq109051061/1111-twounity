using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 圖片方向
    /// </summary>
    public class bird : MonoBehaviour
    {
        #region 更改SpriteRenderer方向
        
        [SerializeField,Header("圖片渲染元件")]
        private SpriteRenderer birdSpriteRenderer;

        private void Start()
        {
            birdSpriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            birdSpriteRenderer.flipX = true;
        }
        
        #endregion
    }
}
