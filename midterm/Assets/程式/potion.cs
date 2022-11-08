using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// Åø¤l®ø¥¢
    /// </summary>
    public class potion : MonoBehaviour
    {
        [SerializeField]
        private string bNameTarget;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            
           if (collision.gameObject.name.Contains(bNameTarget))
            {
                
               Destroy(gameObject);
            }
        }
    }
}
