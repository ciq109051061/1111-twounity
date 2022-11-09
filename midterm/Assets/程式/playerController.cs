using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 玩家控制
    /// </summary>
    public class playerController : MonoBehaviour
    {
        #region 變數宣告

        [SerializeField, Range(0, 10),Header("移動速度")]
        private float speedHorizontal = 4f;

        [SerializeField, Range(0, 20), Header("跳躍速度")]
        private float speedJump = 3f;

        [SerializeField]
        private Animator myAnimator;

        [SerializeField]
        private SpriteRenderer mySpriteRenderer;

        #endregion
       
        private void Start()
        {
            #region 取得元件

            myAnimator = GetComponent<Animator>();
            mySpriteRenderer = GetComponent<SpriteRenderer>();

            #endregion
        }

        private void FixedUpdate()
        {
            #region 玩家移動

            float h = Input.GetAxis("Horizontal");
            float j = Input.GetAxis("Jump");

            transform.Translate(speedHorizontal * Time.deltaTime * h,
                speedJump * Time.deltaTime * j, 0);

            #endregion

            #region 跳躍

            if (Input.GetButton("Jump"))
            {
                myAnimator.SetBool("jump", true);
            }
            else
            {
                myAnimator.SetBool("jump", false);
            }

            #endregion

            #region SpriteRenderer方向

            if (Input.GetKey(KeyCode.D))
            {
                mySpriteRenderer.flipX = false;
            }

            if (Input.GetKey(KeyCode.A))
            {
                mySpriteRenderer.flipX = true;               
            }

            #endregion

            #region 攻擊

            if (Input.GetKeyDown(KeyCode.J))
            {
                myAnimator.SetBool("attack", true);
            }
            else
            {
                myAnimator.SetBool("attack", false);
            }

            #endregion

            #region 跳躍攻擊

            if (Input.GetButton("Jump") && Input.GetKeyDown(KeyCode.J))
            {
                myAnimator.SetBool("jumpattack", true);
            }
            else
            {
                myAnimator.SetBool("jumpattack", false);
            }

            #endregion
        }
    }
}
