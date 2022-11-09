using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 玩家彈幕發射基底
    /// </summary>
    public class fireSystemBase : MonoBehaviour
    {
        #region 預製物&生成點宣告

        [SerializeField, Header("預製物")]
        private GameObject prefabBullet;
        
        [SerializeField, Header("生成點")]
        private Transform pointSpawn;

        #endregion

        protected void SpawnBullet()
        {
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);         
        }

    }
    
}
