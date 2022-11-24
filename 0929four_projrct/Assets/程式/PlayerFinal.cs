using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 玩家結束管理器:死亡或通關
    /// </summary>
    public class PlayerFinal : MonoBehaviour
    {
        #region 死亡

        private void OnDestroy()
        {
            //死亡
            FinallyManager.instance.GameOver("挑戰失敗!");

        }

        #endregion

        #region 勝利

        private void OnTriggerEnter2D(Collider2D collision)
        {
            
                FinallyManager.instance.GameOver("遊戲通過");
            
        }

#endregion
    }
}
