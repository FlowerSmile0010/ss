using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmiPlayer : MonoBehaviour {

    private Animation ani;

  //  public GameObject obj;

    // 指示箭头集合
    public GameObject[] ZhiShiArrowCol;
	// Use this for initialization
	void Start () {

        ani = transform.GetComponent<Animation>();

       // ResetZhiShiArrow();
        
	}

    /// <summary>
    /// 动画一
    /// </summary>
    // 主板和盖子的动画
    public void ZhuBanAndGaiAni() {

        ani.CrossFade("ZhuBanAni");

    }

    /// <summary>
    ///  动画二
    /// </summary>
    // 螺丝部分动画
    public void LuoSiAni() {

        ani.CrossFade("LuoSiAni");
    }

    /// <summary>
    /// 动画三
    /// </summary>
    // 电池部分动画
    public void DianChiAni() {

        ani.CrossFade("DianChiAni");
    }
    /// <summary>
    /// 动画四
    /// </summary>
    // 电池盖部分动画
    public void DianChiGaiAni() {

        ani.CrossFade("DianChiGaiAni");
    }

    /// <summary>
    /// 动画五
    /// </summary>
    // 整体动画
    public void ZhengTiAni() {

        ani.CrossFade("ZhengTiAni");
    }
    // 隐藏所有指示箭头
    public void ResetZhiShiArrow() {

        for (int i = 0; i < ZhiShiArrowCol.Length; i++) {

            if (ZhiShiArrowCol[i].active != false) {

                ZhiShiArrowCol[i].SetActive(false);
            }

            
        }

    }
    // 显示主板指示箭头
    public void ShowZhuBanArrow() {

        ResetZhiShiArrow();
        ZhiShiArrowCol[0].SetActive(true);

    }

    // 显示螺丝指示箭头
    public void ShowLuoSiArrow() {

        ResetZhiShiArrow();
        ZhiShiArrowCol[1].SetActive(true);
    }

    // 显示电池指示箭头
    public void ShowDianChiArrow() {

        ResetZhiShiArrow();
        ZhiShiArrowCol[2].SetActive(true);
    }

    // 显示电池盖指示箭头
    public void ShowDianChiGaiArrow() {

        ResetZhiShiArrow();
        ZhiShiArrowCol[3].SetActive(true);
    }

	// Update is called once per frame
	void Update () {
        
	}
}
