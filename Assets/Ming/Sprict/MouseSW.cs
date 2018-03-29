using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MouseSW : MonoBehaviour ,ITrackableEventHandler
{
    [SerializeField]
    private GameObject[] OnObj;
    [SerializeField]
    private GameObject[] OffObj;
    #region PRIVATE_MEMBER_VARIABLES

    protected TrackableBehaviour mTrackableBehaviour;

    #endregion // PRIVATE_MEMBER_VARIABLES

    #region UNTIY_MONOBEHAVIOUR_METHODS

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }

    void ITrackableEventHandler.OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            //Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
            StartCoroutine(OnTackOn());

        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NOT_FOUND)
        {
            //Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            OnTackOff();
        }
        else
        {
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            OnTackOff();
            
        }
    }

    #endregion// UNTIY_MONOBEHAVIOUR_METHODS


    IEnumerator  OnTackOn()
    {
        yield return new WaitForSeconds(1);
        for (int i = 0; i < OnObj.Length; i++)
        {
            OnObj[i].SetActive(true);
        }
        for (int i = 0; i < OffObj.Length; i++)
        {
            OffObj[i].SetActive(false);
        }
        
    }
    public void OnTackOff()
    {

    }
    // Update is called once per frame
    void Update () {
		
	}

}
