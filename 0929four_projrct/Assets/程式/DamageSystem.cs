using UnityEngine;
namespace Blythe
    {

    public class DamageSystem : MonoBehaviour
    {
        #region 宣告

        [SerializeField,Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField,Header("爆炸預置物")]
        private GameObject prefabExplosion;
        [SerializeField,Header("受傷音效")]
        private AudioClip soundHit;
        [SerializeField,Header("爆炸音效")]
        private AudioClip soundExpiosion;

        #endregion

        #region 碰撞後爆炸

        private void OnCollisionEnter2D(Collision2D collision)
        {
            // print("碰撞" + collision.gameObject);
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                SoundManager.instance.PlaySound(soundHit, new Vector2(0.7f, 0.9f));
                SoundManager.instance.PlaySound(soundExpiosion, new Vector2(1.2f, 1.5f));

                Destroy(gameObject);
            }
        }

        #endregion

        private void OnCollisionExit2D(Collision2D collision)
        {
            
        }
        private void OnCollisionStay2D(Collision2D collision)
        {
            
        }
    }
}