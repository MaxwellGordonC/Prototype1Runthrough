using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Maxwell Gordon
 * Prototype 1
 */
public class LoseOnFall : MonoBehaviour
{
    
    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.bGameOver = true;
        }
    }
}
