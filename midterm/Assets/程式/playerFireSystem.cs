using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// ���a�C��
    /// </summary>
    public class playerFireSystem : fireSystemBase
    {
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.J))
            {
                SpawnBullet();
            }
        }
    }
}
