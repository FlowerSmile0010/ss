using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenJieManager : MonoBehaviour {

    public GameObject[] ArrChaiXie;
    public GameObject MouseSS;
	// Use this for initialization
	void Start () {

        //HideArrChai();
        ShowChaiGaiArr();
    
	}
    //隐藏拆箭头
    public void HideArrChai() {

        for (int i = 0; i < ArrChaiXie.Length; i++) {

            if (ArrChaiXie[i].active != false) {
                
                ArrChaiXie[i].SetActive(false);
            }

        }

    }

    //显示拆盖箭头
    public void ShowChaiGaiArr() {

        HideArrChai();
        ArrChaiXie[0].SetActive(true);
    }

    //显示拆电池箭头
    public void ShowChaiDianChiArr() {

        HideArrChai();
        ArrChaiXie[1].SetActive(true);

    }
    //显示拆螺丝箭头
    public void ShowChaiLuoSiArr() {

        HideArrChai();

        ArrChaiXie[2].SetActive(true);
    }
    //显示拆主板箭头
    public void ShowChaiZhuBanArr() {

        HideArrChai();
        ArrChaiXie[3].SetActive(true);
    }

    public void PlayChaiGaiAni() {

        
        MouseSS.GetComponent<Animation>().CrossFade("CellCap");
    }

    public void PlayTurnAni() {

        MouseSS.GetComponent<Animation>().CrossFade("Overtrun");

        Invoke("PlayChaiGaiAni", 3f);

    }


    public void PlayChaiDianChiAni() {

        MouseSS.GetComponent<Animation>().CrossFade("Cell");
    }


    public void PlayChaiLuoSiAni() {

        MouseSS.GetComponent<Animation>().CrossFade("ScrewDriver");
    }

    public void PlayChaiZhuBanAni() {

        MouseSS.GetComponent<Animation>().CrossFade("CurCuit");
    }
	// Update is called once per frame
	void Update () {

     
	}

   
}
