using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// �l�u�ͦ��I
    /// </summary>
    public class fireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("�l�u�w�s��")]
        private GameObject prefabBullet;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointSpawn;

        protected void SpawnBullet()
        {
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }

    }
    
}
