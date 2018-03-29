using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManagerScr : MonoBehaviour {


    // 几个识别对象数组
    public GameObject[] TargetObjectCol;

    // 主板部分动画元素
    public GameObject[] TargetZhuBanCom;

    public GameObject ZhuBanZhiShiArrow;

    public GameObject LuoSiZhiShiArrow;

    // 隐藏螺丝部分动画部件
    public GameObject[] TargetLuoSiCom;

    //电池零部件
    public GameObject DianChiCom;

    //电池盖零部件
    public GameObject DianChiGaiCom;

    // AR 相机
    private GameObject camObj;

    ////起始鼠标对象
    //public GameObject mouse_startObj;

    ////维修导引子菜单对象
    //public GameObject WeiXiuDaoYinSun;

    public GameObject MRMouseObj;

    public GameObject MouseChaiObj;
	// Use this for initialization
	void Start () {

         camObj = GameObject.Find("ARCamera");
     //   EnterShuBiaoTopShiBie();
      //    EnterZhuBanShiBie();
        
	}

    public void EnterInitShiBie()
    {

        Reset();
        if (TargetObjectCol[5].active != true)
        {

            TargetObjectCol[5].SetActive(true);
        }

    }
    /// <summary>
    /// 显示 鼠标地板 出现UI
    /// </summary>
    // 进入鼠标主板识别状态
    public void EnterZhuBanShiBie() {

       // PlayPressSound();
        Reset();
        if (TargetObjectCol[0].active != true) {

            TargetObjectCol[0].SetActive(true);

            HideZhuBanCom();

            HideLuoSiCom();

            HideDianChiCom();

            HideDianChiGaiCom();
        }
    }

    // 隐藏主板上的指示箭头
    public void HideZhuBanArrow() {

        ZhuBanZhiShiArrow.SetActive(false);
    }

    // 隐藏螺丝指示箭头
    public void HideLuoSiArrow() {

        LuoSiZhiShiArrow.SetActive(false);
    }

    /// <summary>
    /// 鼠标螺丝动画 UI显示
    /// </summary>
    // 进入螺丝识别状态
    public void EnterLuoSiShiBie() {

       // camObj.SetActive(true);
        Reset();
        if (TargetObjectCol[1].active != true) {
            
            TargetObjectCol[1].SetActive(true);
        }


    }
    // 清空识别对象

    void Reset() {

        for (int i = 0; i < TargetObjectCol.Length; i++) {

            if (TargetObjectCol[i].active != false) {

                TargetObjectCol[i].SetActive(false);
            }
        }

    }
    /// <summary>
    ///  电池装动画 UI
    /// </summary>
    // 进入电池识别
    public void EnterDianChiShiBie() {
       
        Reset();

        if (TargetObjectCol[2].active != true) {

            TargetObjectCol[2].SetActive(true);
        }
        
    }

    /// <summary>
    ///  电池盖动画 UI
    /// </summary>

    // 进入电池盖识别状态
    public void EnterDianChiGaiShiBie() {

       
        Reset();

        if (TargetObjectCol[3].active != true) {

            TargetObjectCol[3].SetActive(true);
        }

    }
    // 进入鼠标顶部识别状态
   public void EnterShuBiaoTopShiBie() {

        camObj.SetActive(true);
        Reset();

        if (TargetObjectCol[4].active != true) {

            TargetObjectCol[4].SetActive(true);
        }

     //   HideWeiXiuDaoYinSun();
     
    }

    // 隐藏主板部分动画零件
    public void HideZhuBanCom() {

        for (int i = 0; i < TargetZhuBanCom.Length; i++) {

            TargetZhuBanCom[i].SetActive(false);
        }

    }

    // 显示主板部分动画零件
    public void ShowZhuBanCom() {

        for (int i = 0; i < TargetZhuBanCom.Length; i++) {

            TargetZhuBanCom[i].SetActive(true);
        }

    }

    //隐藏电池零部件
    public void HideDianChiCom() {

        DianChiCom.SetActive(false);

    }

    //显示电池零部件
    public void ShowDianChiCom() {

        DianChiCom.SetActive(true);

    }

    //隐藏电池盖零部件
    public void HideDianChiGaiCom() {

        DianChiGaiCom.SetActive(false);
    }

    //显示电池盖零部件
    public void ShowDianChiGaiCom() {

        DianChiGaiCom.SetActive(true);
    }
    // 隐藏螺丝部分动画部件

    public void HideLuoSiCom() {

        for (int i = 0; i < TargetLuoSiCom.Length; i++) {


            TargetLuoSiCom[i].SetActive(false);
        }
    }

    //显示螺丝部分动画部件
    public void ShowLuoSiCom() {

        for (int i = 0; i < TargetLuoSiCom.Length; i++)
        {


            TargetLuoSiCom[i].SetActive(true);
        }

    }

    ////隐藏维修导引子菜单
    //public void HideWeiXiuDaoYinSun() {

    //    WeiXiuDaoYinSun.SetActive(false);
    //}

    ////显示维修导引子菜单
    //public void ShowWeiXiuDaoYinSun() {


    //    PlayPressSound();
    //    WeiXiuDaoYinSun.SetActive(true);

    //}

    //播放声音
    public void PlayPressSound() {

        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();
    }

    /// <summary>
    /// 鼠标分解部分
    /// </summary>
    //鼠标分解
    public void EnterMouseFenJie() {

        //鼠标分解内容

        PlayPressSound();
    }

    //进入电子手册
    public void EnterDianZiShouCe() {

        PlayPressSound();

    }

    //进入认知培训
    public void EnterRenZhiPeiXun() {

        PlayPressSound();

    }

    public void EnterChaiState001() {
        
        Reset();

        if (TargetObjectCol[4].active != true)
        {

            TargetObjectCol[4].SetActive(true);
        }

        if (TargetObjectCol[3].active != true)
        {

            TargetObjectCol[3].SetActive(true);
        }
        StateManager.CurrentState = 1;
        
    }


    public void EnterZhuangState001() {

        EnterZhuBanShiBie();
        StateManager.CurrentState = 2;

        if (MouseChaiObj != null && MouseChaiObj.active!=false) {

            MouseChaiObj.GetComponent<FenJieManager>().HideArrChai();
        }
        MRMouseObj.GetComponent<AmiPlayer>().ResetZhiShiArrow();
        MRMouseObj.GetComponent<AmiPlayer>().ShowZhuBanArrow();
        
    }
        

}
