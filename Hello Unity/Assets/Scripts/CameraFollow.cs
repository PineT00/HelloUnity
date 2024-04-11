using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    public GameObject target;
    public Vector3 offset;

    void Start()
    {
        player = GameObject.FindWithTag("Player");

        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Vector3 dir = player.transform.position;
        //offSet = new Vector3(-10, 10, 0);

        transform.position = target.transform.position + offset;

        transform.LookAt(player.transform);
    }
}
