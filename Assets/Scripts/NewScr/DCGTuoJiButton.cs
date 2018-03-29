using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DCGTuoJiButton : MonoBehaviour {

    void OnSelect()
    {

        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();

        GameObject.Find("ARCamera").SetActive(false);
    }
}
