using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// ���l�ͦ��t��
    /// </summary>
    public class birdAttackSystem : fireSystemBase
    {
        [SerializeField, Header("�ͦ����j"), Range(0, 10)]
        private float bInterval = 1.5f;
        private void Awake()
        {
            InvokeRepeating("SpawnBullet", 0, bInterval);
        }
    }
}
