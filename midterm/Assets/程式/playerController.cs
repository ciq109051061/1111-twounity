using UnityEngine;

namespace Blythe
{

    public class playerController : MonoBehaviour
    {
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;

        [SerializeField, Range(0, 20)]
        private float speedJump = 3f;

        [SerializeField]
        private Animator myAnimator;

        [SerializeField]
        private SpriteRenderer mySpriteRenderer;

        private void Start()
        {
            myAnimator = GetComponent<Animator>();
            mySpriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void FixedUpdate()
        {
            float h = Input.GetAxis("Horizontal");
            float j = Input.GetAxis("Jump");

            transform.Translate(speedHorizontal * Time.deltaTime * h,
                speedJump * Time.deltaTime * j, 0);

            if (Input.GetButton("Jump"))
            {
                myAnimator.SetBool("jump", true);
            }
            else
            {
                myAnimator.SetBool("jump", false);
            }



            if (Input.GetButton("Horizontal"))
            {
                myAnimator.SetBool("walk", true);
            }
            else
            {
                myAnimator.SetBool("walk", false);
            }

            if (Input.GetKey(KeyCode.D))
            {
                mySpriteRenderer.flipX = false;
            }

            if (Input.GetKey(KeyCode.A))
            {
                mySpriteRenderer.flipX = true;
               
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                myAnimator.SetBool("attack", true);
            }
            else
            {
                myAnimator.SetBool("attack", false);
            }

            if (Input.GetButton("Jump") && Input.GetKeyDown(KeyCode.J))
            {
                myAnimator.SetBool("jumpattack", true);
            }
            else
            {
                myAnimator.SetBool("jumpattack", false);
            }

        }
    }
}
