using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 小火龍噴火
    /// </summary>
    public class dragonFireSystem : fireSystemBase
    {
        #region 自動噴火

        [SerializeField, Header("生成間隔"), Range(0, 10)]
        private float dInterval = 1.5f;
        
        private void Awake()
        {
            InvokeRepeating("SpawnBullet", 0, dInterval);
        }

        #endregion
    }
}
