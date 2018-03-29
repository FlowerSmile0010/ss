using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhuBanPalyAni : MonoBehaviour {

    private StateManagerScr stam;

    public GameObject MRMouseObj;
	// Use this for initialization
	void Start () {

        stam = GameObject.Find("StateManagerScr").GetComponent<StateManagerScr>();
		
	}

    void OnSelect() {

        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();

        stam.ShowZhuBanCom();

        MRMouseObj.GetComponent<AmiPlayer>().ZhuBanAndGaiAni();
        
    }
	// Update is called once per frame
	void Update () {
		
	}
}
