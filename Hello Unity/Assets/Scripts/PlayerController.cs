using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f; 
    private Rigidbody rb;

    void Start()
    {
        // Rigidbody ������Ʈ ��������
        rb = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // �̵� ���� ���
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
        Vector3 velocity = moveDirection * speed;

        // �̵�
        rb.MovePosition(rb.position + transform.TransformDirection(velocity) * Time.deltaTime);
    }



}
