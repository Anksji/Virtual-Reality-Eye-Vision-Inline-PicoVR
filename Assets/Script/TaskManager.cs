using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{
    [SerializeField] Transform targetTransform;
    float scaleFactor = 0.5f;
    private GameObject targetObject;
   
    public void methodCalled(float scaleFactor,GameObject currentObj)
    {
        this.targetObject = currentObj;
        this.scaleFactor = scaleFactor;
    }

    internal void applyZoomIn()
    {
        if(targetObject!=null)
            targetObject.transform.localScale+= new Vector3(scaleFactor, scaleFactor, scaleFactor);
       
    }
    internal void applyZoomOut()
    {
        if (targetObject != null)
            targetObject.transform.localScale -= new Vector3(scaleFactor, scaleFactor, scaleFactor);
    }
}
