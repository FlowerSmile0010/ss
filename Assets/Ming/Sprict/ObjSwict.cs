using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjSwict : MonoBehaviour {
    public List<GameObject> objlist;   // Use this for initialization
    void Start () {
        objlist.Clear();
	}
	
	// Update is called once per frame
	void Update () {
		
	}/// <summary>
    /// 批量激活
    /// </summary>
    public void SwictOn()
    {
        if (objlist.Count>0)
        {
            for (int i = 0; i < objlist.Count; i++)
            {
                objlist[i].SetActive(true);
            }
            objlist.Clear();
        }
            
    }/// <summary>
    /// 批量隐藏
    /// </summary>
    public void SwictOff()
    {
        if (objlist.Count > 0)
        {
            for (int i = 0; i < objlist.Count; i++)
            {
                objlist[i].SetActive(false);
            }
            objlist.Clear();
        }
    }
}
