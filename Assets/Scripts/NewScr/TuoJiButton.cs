using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuoJiButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		


	}

    void OnSelect() {

        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();
        GameObject.Find("MRMouse").transform.parent = null;
  //      GameObject.Find("ARCamera").SetActive(false);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
