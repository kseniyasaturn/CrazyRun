using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private MovementHandler movementHandler;


    public void TimerOff()
    {
        timer.enabled = false;
    }

    public void MovingOff()
    {
        movementHandler.enabled=false;
    }
}
