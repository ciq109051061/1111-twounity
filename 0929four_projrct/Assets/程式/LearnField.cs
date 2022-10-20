using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 學習欄位
    /// </summary>
    
    public class LearnField : MonoBehaviour
    {
        // 欄位 Field:儲存資料
        // 語法:
        // 修飾詞 資料類型 欄位名稱
        // 私人:private，僅在此類別能夠存取
        private int lv;
        public int heart = 10;
        public float speed = 2.5f;
        public float jump = 3.2f;
        public string usename = "小騎士";
        public bool ispass = false;
        public bool weapoon = true;

        [Header("血量")]
        public int hp = 999;
        [Tooltip("玩家遊玩經過的時間")]
        public float playtime = 10.5f;
        [Tooltip("玩家的等級")]
        [Range(1, 10)]
        public int level = 10;
        [Range(2f,10.5f)]
        [Tooltip("玩家走路速度")]
        public float walkspace = 2.5f;
        [SerializeField]
        public int countboom = 7;






       
    }
}