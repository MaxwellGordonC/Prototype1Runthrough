using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerIncrementScore : MonoBehaviour
{
    public int IncrementValue;
    private bool bTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if ( other.CompareTag("Player") && !bTriggered )
        {
            bTriggered = true;
            ScoreManager.score += IncrementValue;
        }
    }
}
