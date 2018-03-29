using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuoSiNextButton : MonoBehaviour
{

    private StateManagerScr stam;

    //鼠标对象
    public GameObject mrmouseObj;
    
    // Use this for initialization
    void Start()
    {


        stam = GameObject.Find("StateManagerScr").GetComponent<StateManagerScr>();

    }
    void OnSelect()
    {

        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();
        GameObject.Find("ARCamera").SetActive(true);
        stam.EnterDianChiShiBie();
        mrmouseObj.GetComponent<AmiPlayer>().ShowDianChiArrow();
        
    }
    // Update is called once per frame
    void Update()
    {

    }
}
