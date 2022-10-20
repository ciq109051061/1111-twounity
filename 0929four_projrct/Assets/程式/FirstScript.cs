using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// 第一個程式
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region 註解區域
        // Start is called before the first frame update
        

        #endregion
        #region 事件區域
        private void Awake()
        {
            print("helloword");   
        }
        private void Start()
        {
            print("<color=yellow>這是開始事件</color>");  
        }
        private void Update()
        {
            print("<color=green>更新事件!</color>");
        }
        #endregion

    }

}