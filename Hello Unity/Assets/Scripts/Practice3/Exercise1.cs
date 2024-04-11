using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    float rotSpeed = 360f;
    float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        //transform.Rotate(0, h * rotSpeed * Time.deltaTime, 0);
        transform.rotation *= Quaternion.Euler(0, h * rotSpeed * Time.deltaTime, 0);


        Vector3 dir = new Vector3(h, 0, v);
        dir.Normalize();


        //transform.position += dir * speed * Time.deltaTime;

    }
}
