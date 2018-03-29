using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public GameObject FenJieClone;

    public GameObject ZhuangObj;

	// Use this for initialization
	void Start () {

        HideMenu();
		
	}
    void HideMenu() {

        FenJieClone.SetActive(false);

      //  ZhuangObj.SetActive(false);
    }

    public void ShowFenJie() {

        HideMenu();
        FenJieClone.SetActive(true);
    }

    public void ShowZhuangPei() {

        HideMenu();

        ZhuangObj.SetActive(true);
    }

    public void ShowFenJieObj() {

        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();
        //if (GameObject.Find("ZhuZhuang(Clone)") != null) {

        //    Destroy(GameObject.Find("ZhuZhuang(Clone)"));
        //}
        
        GameObject fenObj = Resources.Load("FenJie") as GameObject;
        if (FenJieClone == null) {

            FenJieClone = Instantiate(fenObj);
            FenJieClone.transform.parent = null;
            FenJieClone.transform.localPosition = Vector3.zero;
            FenJieClone.transform.localRotation = Quaternion.Euler(0, 0, 0);
            FenJieClone.transform.localScale = Vector3.one;
        }
       

      //  FenJieObj.SetActive(true);
    }

    public void ShowZhuangObj() {

        //GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();

        //if (GameObject.Find("FenJie(Clone)") != null) {

        //    Destroy(GameObject.Find("FenJie(Clone)"));
        //}
       
        GameObject fenObj = Resources.Load("ZhuZhuang") as GameObject;

        if (ZhuangObj == null) {

            ZhuangObj = Instantiate(fenObj);
            ZhuangObj.transform.parent = null;
            ZhuangObj.transform.localPosition = Vector3.zero;
            ZhuangObj.transform.localRotation = Quaternion.Euler(0, 0, 0);
            ZhuangObj.transform.localScale = Vector3.one;
        }
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) {

            ShowFenJieObj();
        }
        if (Input.GetKeyDown(KeyCode.W)) {


            ShowZhuangObj();
        }
    }

    //  public 
}
