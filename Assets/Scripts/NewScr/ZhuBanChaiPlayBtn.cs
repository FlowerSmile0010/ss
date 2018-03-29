using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhuBanChaiPlayBtn : MonoBehaviour {

    public GameObject MouseSS;
    
    void OnSelect()
    {

        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();
        MouseSS.GetComponent<FenJieManager>().PlayChaiZhuBanAni();
       
    }
    
}
