using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    [SerializeField] private Text timerText;
    private float timeLeft;
    public bool isPlaying;
    [SerializeField] private UnityEvent timeOver;

    public void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        isPlaying = true;
        timeLeft = 30f;
        timerText.text = timeLeft.ToString("F0");
    }


    private void Update()
    {
        if (isPlaying)
        {
            timeLeft -= Time.deltaTime;

            timerText.text = timeLeft.ToString("F0");

            if (timeLeft <= 0f)
            {
                isPlaying = false;
                timeOver.Invoke();
            }
        }
    }
}
