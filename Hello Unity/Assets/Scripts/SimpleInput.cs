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
            point.z = 10f; //3�������� Ŭ���� x,y ��ǥ�� ������ ī�޶�~���� ��ü������ �Ÿ���ǥ z
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
