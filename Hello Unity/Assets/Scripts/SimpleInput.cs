using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void Update()
    {
        var x = Input.GetAxis("Mouse X");
        var y = Input.GetAxis("Mouse Y");
        //Debug.Log($"{x}{y}");

        if (Input.GetButton("Jump"))
        {
            Debug.Log("Jumping");
        }



        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Down");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mouse Up");
            Debug.Log(Input.mousePosition);

            var point = Input.mousePosition;
            point.z = 10f; //3차원에서 클릭시 x,y 좌표를 제외한 카메라~실제 물체까지의 거리좌표 z
            Debug.Log(Camera.main.ScreenToWorldPoint(point));
        }



        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A Down");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("A Up");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("AAAAAAAA");
        }

        if (Input.anyKey)
        {
            Debug.Log("any Key Pressing");
        }
        if (Input.anyKeyDown)
        {
            Debug.Log("any key Down");
        }
    }
}
