using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Goal : MonoBehaviour
{
    public UnityEvent GoalEvent;
    private void OnTriggerEnter(Collider other)
    {
        GoalEvent.Invoke();
    }
}
