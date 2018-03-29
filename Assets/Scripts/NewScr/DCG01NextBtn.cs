using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DCG01NextBtn : MonoBehaviour {

    public GameObject mouse_SS;

    public GameObject DianChiGaiObj;
	// Use this for initialization
	
    void OnSelect() {

        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();

        mouse_SS.transform.parent = null;

        DianChiGaiObj.SetActive(false);

        GameObject.Find("StateManagerScr").GetComponent<StateManagerScr>().EnterDianChiShiBie();

        mouse_SS.GetComponent<FenJieManager>().ShowChaiDianChiArr();
        

    }
	// Update is called once per frame
	void Update () {
		
	}
}
