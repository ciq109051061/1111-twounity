using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// �ǲ����
    /// </summary>
    
    public class LearnField : MonoBehaviour
    {
        // ��� Field:�x�s���
        // �y�k:
        // �׹��� ������� ���W��
        // �p�H:private�A�Ȧb�����O����s��
        private int lv;
        public int heart = 10;
        public float speed = 2.5f;
        public float jump = 3.2f;
        public string usename = "�p�M�h";
        public bool ispass = false;
        public bool weapoon = true;

        [Header("��q")]
        public int hp = 999;
        [Tooltip("���a�C���g�L���ɶ�")]
        public float playtime = 10.5f;
        [Tooltip("���a������")]
        [Range(1, 10)]
        public int level = 10;
        [Range(2f,10.5f)]
        [Tooltip("���a�����t��")]
        public float walkspace = 2.5f;
        [SerializeField]
        public int countboom = 7;






       
    }
}