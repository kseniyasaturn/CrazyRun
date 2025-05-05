using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] private InputHandler inputHandler;
    [SerializeField] private float ballSpeed;

    void Start()
    {
        if(inputHandler == null) Debug.LogError( "input handler не назначен");
    }

    private void MoveBall()
    {
        if (inputHandler.IsThereTouchOnScreen())
        {
            Vector2 currDeltaPos  = inputHandler.GetTouchDeltaPosition();
            currDeltaPos = currDeltaPos * ballSpeed;
            Vector3 newGravityVector = new Vector3 (currDeltaPos.x, Physics.gravity.y, currDeltaPos.y);
            Physics.gravity = newGravityVector;
        }
    }


    void Update()
    {
        MoveBall();
    }
}
