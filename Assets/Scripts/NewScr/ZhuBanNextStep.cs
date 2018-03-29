using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhuBanNextStep : MonoBehaviour {

    private StateManagerScr stam;

    //鼠标对象
    public GameObject mrmouseObj;
    
	// Use this for initialization
	void Start () {


        stam = GameObject.Find("StateManagerScr").GetComponent<StateManagerScr>();
		
	}
    void OnSelect() {

        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();

        mrmouseObj.transform.parent = null;
        
       // GameObject.Find("ARCamera").SetActive(true);

        stam.EnterLuoSiShiBie();

        mrmouseObj.GetComponent<AmiPlayer>().ShowLuoSiArrow();


    }
	// Update is called once per frame
	void Update () {
		
	}
}
