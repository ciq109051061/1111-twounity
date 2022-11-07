using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// ª±®a¼C®ð
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
