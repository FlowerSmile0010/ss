using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LS01CBtn : MonoBehaviour
{
    public GameObject FenJieManObj;

    public GameObject[] LuoSiCol;
   
    void OnSelect()
    {

        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();

        GameObject.Find("ARCamera").SetActive(true);

        for (int i = 0; i < LuoSiCol.Length; i++) {


            LuoSiCol[i].SetActive(false);


        }

        GameObject.Find("StateManagerScr").GetComponent<StateManagerScr>().EnterZhuBanShiBie();

        FenJieManObj.GetComponent<FenJieManager>().ShowChaiZhuBanArr();

    }

}
