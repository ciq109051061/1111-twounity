using UnityEngine;

namespace Blythe
{
    public class enemyFireSystemBass : MonoBehaviour
    {

        [SerializeField, Header("�l�u�w�s��")]
        private GameObject prefabBullet;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointSpawn;

        [SerializeField]
        private Transform pointSpawn02;

        [SerializeField]
        private Transform pointSpawn03;

        [SerializeField]
        private Transform pointSpawn04;

        [SerializeField]
        private Transform pointSpawn05;

        protected void SpawnBullet()
        {
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
            Instantiate(prefabBullet, pointSpawn02.position, pointSpawn.rotation);
            Instantiate(prefabBullet, pointSpawn03.position, pointSpawn.rotation);
            Instantiate(prefabBullet, pointSpawn04.position, pointSpawn.rotation);
            Instantiate(prefabBullet, pointSpawn05.position, pointSpawn.rotation);


        }

    }
}
