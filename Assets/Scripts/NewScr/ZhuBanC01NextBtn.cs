using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhuBanC01NextBtn : MonoBehaviour {

    public GameObject MouseSS;

    public GameObject[] ZhuBanBuJian;

    public GameObject txt_WanChengObj;

    void OnSelect() {

        GameObject.Find("ARCamera").SetActive(true);

        for (int i = 0; i < ZhuBanBuJian.Length; i++) {

            ZhuBanBuJian[i].SetActive(false);

        }
        txt_WanChengObj.SetActive(true);

        Invoke("HideMouseObj", 3);

    }

    void HideMouseObj() {

        MouseSS.SetActive(false);
    }
}
