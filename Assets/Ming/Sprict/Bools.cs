//using HoloToolkit.Unity.InputModule;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Bools : MonoBehaviour {

//    [Tooltip("旋转速度")]
//    public float RotationSensitivity = 10.0f;

//    [Tooltip("移动速度")]
//    public float MoveSensitivity = 1.5f;

//    //Cube移动前的位置
//    private Vector3 origPosition;

//    public void OnManipulationCanceled(ManipulationEventData eventData)
//    {
//        //do nothing
//    }

//    public void OnManipulationCompleted(ManipulationEventData eventData)
//    {
//        //do nothing
//    }

//    public void OnManipulationStarted(ManipulationEventData eventData)
//    {
//        // 开始移动前，保存Cube原始位置
//        origPosition = transform.position;
//    }

//    public void OnManipulationUpdated(ManipulationEventData eventData)
//    {
//        // 获取拖拽的总偏移量
//        Vector3 newPos = new Vector3(eventData.CumulativeDelta.x, eventData.CumulativeDelta.y, eventData.CumulativeDelta.z);

//        // 设置Cube新的位置
//        transform.position = origPosition + newPos * MoveSensitivity;
//    }

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
//        // 计算旋转值，其中：eventData的CumulativeDelta返回导航差值，值域[-1, 1]
//        float rotationFactor = eventData.CumulativeDelta.x * RotationSensitivity;
//        transform.Rotate(new Vector3(0, -1 * rotationFactor, 0));
//    }
//}
