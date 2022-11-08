using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// �p���s�Q��
    /// </summary>
    public class dragonFireSystem : fireSystemBase
    {
        [SerializeField, Header("�ͦ����j"), Range(0, 10)]
        private float dInterval = 1.5f;
        private void Awake()
        {
            InvokeRepeating("SpawnBullet", 0, dInterval);
        }
    }
}
