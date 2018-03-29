using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaSwoct : MonoBehaviour {
    Animator Anima; 
	// Use this for initialization
	void Start () {
        Anima = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AnimaSwOn(string name)
    {
        Anima.SetBool(name,true);


    }
    public void AnimaSwOff(string name)
    {
        Anima.SetBool(name, false);
    }
}
