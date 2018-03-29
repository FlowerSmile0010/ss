using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DC01NextBtn : MonoBehaviour {
    public GameObject FenJieManObj;

    public GameObject DianChiObj;
    // Use this for initialization
    void Start () {
		
	}

    void OnSelect()
    {

        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();

        GameObject.Find("ARCamera").SetActive(true);

        DianChiObj.SetActive(false);

        GameObject.Find("StateManagerScr").GetComponent<StateManagerScr>().EnterLuoSiShiBie();

        FenJieManObj.GetComponent<FenJieManager>().ShowChaiLuoSiArr();


    }

    // Update is called once per frame
    void Update () {
		
	}
}
