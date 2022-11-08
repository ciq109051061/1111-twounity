using UnityEngine;

namespace Blythe
{

    public class enemyFireSystem : enemyFireSystemBass
    {
        [SerializeField, Header("¥Í¦¨¶¡¹j"), Range(0, 10)]
        private float eInterval = 1.5f;
        private void Awake()
        {
            InvokeRepeating("SpawnBullet", 0, eInterval);
        }
    }
}
