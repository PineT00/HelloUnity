using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    public GameObject go;
    public MeshRenderer ren;
    public Material redMaterial;

    void Start()
    {

        //var ren1 = gameObject.GetComponent<MeshRenderer>(); //���� "��" ���� ������Ʈ�� �޽������� ã��
        //var ren = GetComponent<MeshRenderer>(); //�Ѵ� ��� ����

        //ren.material.color = Color.red;

        ren.material = redMaterial;

        //var go = GameObject.FindWithTag("Wall");
        //go.SetActive(false);
    }


    void Update()
    {


    }
}
