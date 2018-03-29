using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAniController : MonoBehaviour {

    public GameObject ProductImageObj;

    public GameObject MouseAnimator;
    private static int i = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A)) {


            ProductImageObj.GetComponent<Animator>().SetBool("Image_open", true);
            
        }

        
       
	}
}
