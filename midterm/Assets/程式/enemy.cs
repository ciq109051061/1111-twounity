using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 怪物動畫
    /// </summary>
    public class enemy : MonoBehaviour
    {
        #region 播放怪物動畫

        [SerializeField]
        private Animator enemyAnimator;

        private void Start()
        {
            enemyAnimator = GetComponent<Animator>();
        }

        private void Update()
        {
            enemyAnimator.SetBool("enemy", true);
        }
        
        #endregion
    }
}
