using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowOffset : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 dir = player.transform.position;

        transform.position = dir + offset;

        transform.LookAt(player.transform);
    }
}
