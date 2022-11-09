using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 罐子消失
    /// </summary>
    public class potion : MonoBehaviour
    {
        [SerializeField,Header("碰到該關鍵字罐子消失")]
        private string bNameTarget;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            #region 碰撞消失

            if (collision.gameObject.name.Contains(bNameTarget))
            {
                
               Destroy(gameObject);
            }

            #endregion
        }
    }
}
