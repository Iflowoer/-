using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;



public class MainBgm : MonoBehaviour
{

    void Start()
    {

        DontDestroyOnLoad(transform.gameObject); // 이렇게 하면 다음 scene으로 넘어가도 오브젝트가 사라지지 않습니다.

    }


}
