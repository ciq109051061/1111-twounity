using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 移動系統
    /// </summary>
    public class moveSystem : MonoBehaviour
    {
        #region 移動

        [SerializeField, Header("移動速度"), Range(-10, 0)]
        private float speed = -3.5f;
        
        private void Update()
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        #endregion
    }
}
