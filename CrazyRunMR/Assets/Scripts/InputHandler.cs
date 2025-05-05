using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Vector2 GetTouchDeltaPosition()      
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase is TouchPhase.Began or TouchPhase.Moved)
        {
            return Input.GetTouch(0).deltaPosition;
        }
        return Vector2.zero;
    }

  
    public bool IsThereTouchOnScreen()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase is TouchPhase.Began or TouchPhase.Moved)
        {
            return true;
        }
        else return false;
    }
    private void Update()
    {
        Debug.Log(IsThereTouchOnScreen() + "тач");
    }
}
