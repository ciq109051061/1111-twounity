using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 敵人彈幕發射基底
    /// </summary>
    public class enemyFireSystemBass : MonoBehaviour
    {
        #region 預製物&生成點宣告

        [SerializeField, Header("預製物")]
        private GameObject prefabBullet;
        
        [SerializeField, Header("生成點")]
        private Transform pointSpawn;

        [SerializeField]
        private Transform pointSpawn02;

        [SerializeField]
        private Transform pointSpawn03;

        [SerializeField]
        private Transform pointSpawn04;

        [SerializeField]
        private Transform pointSpawn05;

        #endregion

        protected void SpawnBullet()
        {
            #region 自動生成

            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);

            Instantiate(prefabBullet, pointSpawn02.position, pointSpawn.rotation);

            Instantiate(prefabBullet, pointSpawn03.position, pointSpawn.rotation);

            Instantiate(prefabBullet, pointSpawn04.position, pointSpawn.rotation);

            Instantiate(prefabBullet, pointSpawn05.position, pointSpawn.rotation);

#endregion
        }

    }
}
