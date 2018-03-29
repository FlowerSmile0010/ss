using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DCGPlayButton : MonoBehaviour
{

    private StateManagerScr stam;

    public GameObject MRMouseObj;
    // Use this for initialization
    void Start()
    {

        stam = GameObject.Find("StateManagerScr").GetComponent<StateManagerScr>();

    }

    void OnSelect()
    {

        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();

        stam.ShowDianChiGaiCom();

        MRMouseObj.GetComponent<AmiPlayer>().DianChiGaiAni();

    }


    // Update is called once per frame
    void Update()
    {

    }
}