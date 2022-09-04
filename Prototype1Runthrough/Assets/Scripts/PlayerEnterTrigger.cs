using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Maxwell Gordon
 * Prototype 1
 */
public class PlayerEnterTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if ( other.CompareTag("TriggerEndGame") )
        {
            ScoreManager.score++;
        }
    }
}
