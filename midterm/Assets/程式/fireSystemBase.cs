using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 쨖펥Ν┬헕
    /// </summary>
    public class fireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("쨖펥퉥퍀か")]
        private GameObject prefabBullet;
        [SerializeField, Header("쨖펥Ν┬헕")]
        private Transform pointSpawn;

        protected void SpawnBullet()
        {
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }

    }
    
}
