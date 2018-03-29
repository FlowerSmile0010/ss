//using HoloToolkit.Unity.InputModule;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CubeRot : MonoBehaviour,INavigationHandler
//{

//    [Tooltip("旋转速度")]
//    public float RotationSensitivity = 10.0f;

//    public void OnNavigationCanceled(NavigationEventData eventData)
//    {
//        //do nothing
//    }

//    public void OnNavigationCompleted(NavigationEventData eventData)
//    {
//        //do nothing
//    }

//    public void OnNavigationStarted(NavigationEventData eventData)
//    {
//        //do nothing
//    }

//    public void OnNavigationUpdated(NavigationEventData eventData)
//    {
//        // 计算旋转值，其中：eventData的CumulativeDelta返回手势导航差值，值域[-1, 1]
//        float rotationFactor = eventData.CumulativeDelta.x * RotationSensitivity;
//        transform.Rotate(new Vector3(0, -1 * rotationFactor, 0));
//    }

//}
