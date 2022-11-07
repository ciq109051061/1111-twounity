using UnityEngine;

namespace Blythe
{

    public class playerController : MonoBehaviour
    {
        
        [SerializeField]
        private Animator myAnimator;
        
        private void Start()
        {
            myAnimator = GetComponent<Animator>();
        }
        private void Update()
        {
            
            if(Input.GetButton("Horizontal"))
            {
                myAnimator.SetBool("walk", true);
            }
            else
            {
                myAnimator.SetBool("walk", false);
            }
        }
    }
}
