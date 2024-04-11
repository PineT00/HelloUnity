using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPractice : MonoBehaviour
{
    private Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");

        //var up = Input.GetButton("Ascent");
        //var down = Input.GetButton("Descent");

        if(Input.GetButton("Ascent"))
        {
            dir = new Vector3(h, 1, v);
        }
        else if (Input.GetButton("Descent"))
        {
            dir = new Vector3(h, -1, v);
        }
        else
        {
            dir = new Vector3(h, 0, v);
        }
        dir.Normalize();

        transform.position += dir * 10f * Time.deltaTime;

    }
}
