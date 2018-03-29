using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DianChiPlayButton : MonoBehaviour
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

        stam.ShowDianChiCom();

        MRMouseObj.GetComponent<AmiPlayer>().DianChiAni();

    }


    // Update is called once per frame
    void Update()
    {

    }
}