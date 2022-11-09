using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 玩家受傷
    /// </summary>
    public class playerDamageSystem : MonoBehaviour
    {
        #region 宣告

        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField, Header("爆炸預置物")]
        private GameObject prefabExplosion;

        private Animator myAnimator;

        #endregion

        private void Start()
        {
            //取得animator元件
            myAnimator = GetComponent<Animator>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            #region 受傷死亡

            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);               
                Destroy(gameObject);
            }

            #endregion
        }

    }
}
