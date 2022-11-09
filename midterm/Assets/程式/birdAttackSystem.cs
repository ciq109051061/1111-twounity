using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 罐子生成系統
    /// </summary>
    public class birdAttackSystem : fireSystemBase
    {
        #region 罐子生成

        [SerializeField, Header("生成間隔"), Range(0, 10)]
        private float bInterval = 1.5f;
        private void Awake()
        {
            InvokeRepeating("SpawnBullet", 0, bInterval);
        }

        #endregion
    }
}
