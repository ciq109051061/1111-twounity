using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Blythe
{
    /// <summary>
    /// �Ĥ@�ӵ{��
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region ���Ѱϰ�
        // Start is called before the first frame update
        

        #endregion
        #region �ƥ�ϰ�
        private void Awake()
        {
            print("helloword");   
        }
        private void Start()
        {
            print("<color=yellow>�o�O�}�l�ƥ�</color>");  
        }
        private void Update()
        {
            print("<color=green>��s�ƥ�!</color>");
        }
        #endregion

    }

}