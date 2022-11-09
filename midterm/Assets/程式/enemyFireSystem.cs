using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 敵人發射系統
    /// </summary>
    public class enemyFireSystem : enemyFireSystemBass
    {
        #region 彈幕發射

        [SerializeField, Header("生成間隔"), Range(0, 10)]
        private float eInterval = 1.5f;
        
        private void Awake()
        {
            InvokeRepeating("SpawnBullet", 0, eInterval);
        }

        #endregion
    }
}
