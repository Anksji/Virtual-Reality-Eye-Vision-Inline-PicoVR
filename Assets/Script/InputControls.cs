using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputControls : MonoBehaviour
{

    public InputActionProperty LeftHandInput;
    public InputActionProperty RightHandInput;
    public bool isReady = true;
    public TaskManager taskManger;

    enum ButtonPressed
    {
        zoomIN, zoomOut
    }
    void Update()
    {
        if (isReady)
        {
            bool isPressed = RightHandInput.action.IsPressed();
            if (isPressed)
            {
                StartCoroutine(ZoomInZoomOut(ButtonPressed.zoomIN));
                return;
            }

            isPressed = LeftHandInput.action.IsPressed();

           
            if (isPressed)
            {
                StartCoroutine(ZoomInZoomOut(ButtonPressed.zoomOut));
                return;
            }
        }

    }

    IEnumerator ZoomInZoomOut(ButtonPressed pressedBtn)
    {
        if (pressedBtn == ButtonPressed.zoomIN)
        {
            taskManger.applyZoomIn();
        }
        else
        {
            taskManger.applyZoomOut();
        }

        isReady = false;
        yield return new WaitForSeconds(0.5f);
        isReady = true;

    }
}
