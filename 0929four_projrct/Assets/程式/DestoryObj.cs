using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// �R������
    /// </summary>
    public class DestoryObj : MonoBehaviour
    {
        [SerializeField,Header("�R���ɶ�"),Range(0,3)]
        private float destroyTime = 0.5f;

        private void Awake()
        {
            //�R��(����A�R���ɶ�)
            Destroy(gameObject, destroyTime);

        }

        //�i���ƥ�:���V����(Renderer)�X�{�bScene �� Game �ɰ���@��
        private void OnBecameVisible()
        {
            
        }

        //���i���ƥ�:���V����(Renderer)�����bScene �� Game �ɰ���@��
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }

    }
}
