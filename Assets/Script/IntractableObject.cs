using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntractableObject : MonoBehaviour
{
    public TaskManager taskManager;
    public float ScaleFactor = 0.5f;
   
    public void intracting(bool isEnter)
    {
        if (isEnter)
            taskManager.methodCalled(ScaleFactor, gameObject);
        else
            taskManager.methodCalled(0, null);
    }
    

}
