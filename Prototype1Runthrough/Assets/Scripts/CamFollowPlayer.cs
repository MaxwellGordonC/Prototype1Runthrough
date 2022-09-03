using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Maxwell Gordon
 * Prototype 1
 */

public class CamFollowPlayer : MonoBehaviour
{
    // MaxG: Get Player ref.
    public GameObject player;
    private Vector3 cam_offset = new Vector3(0, 5, -10);

    void Update()
    {
        transform.position = player.transform.position + cam_offset;
    }
}
