using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DCG01TuoJiBtn : MonoBehaviour {

    public GameObject MouseSS;
    void OnSelect() {


        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();
        MouseSS.transform.parent = null;
       // GameObject.Find("ARCamera").SetActive(false);

        
    }
}
