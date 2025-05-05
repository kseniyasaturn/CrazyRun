using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

public class GameConditions : MonoBehaviour
{
    [SerializeField] private GameObject completeScreen;
    [SerializeField] private GameObject defeatScreen;
    [SerializeField] private UnityEvent timeOff;
    [SerializeField] private UnityEvent movingOff;


    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Rigidbody>(out Rigidbody rigidbody))
        {
            completeScreen.SetActive(true);
            timeOff.Invoke();
            movingOff.Invoke();
        }
    }

   public void TimeOver()
    {
         defeatScreen.gameObject.SetActive(true);
         timeOff.Invoke();
         movingOff.Invoke();
    }
}
