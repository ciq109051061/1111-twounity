using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 玩家劍氣
    /// </summary>
    public class playerFireSystem : fireSystemBase
    {
        private void Update()
        {
            #region 劍氣發射

            if (Input.GetKeyDown(KeyCode.J))
            {
                SpawnBullet();
            }

            #endregion
        }
    }
}
