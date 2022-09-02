using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseOnFall : MonoBehaviour
{
    public Text textbox;

    
    void Update()
    {
        if (transform.position.y < -1)
        {
            textbox.text = "You lose!";
        }
    }
}
