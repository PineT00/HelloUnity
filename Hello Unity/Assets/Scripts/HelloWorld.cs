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

        //var ren1 = gameObject.GetComponent<MeshRenderer>(); //지금 "이" 게임 오브젝트의 메쉬렌더러 찾기
        //var ren = GetComponent<MeshRenderer>(); //둘다 결과 같음

        //ren.material.color = Color.red;

        ren.material = redMaterial;

        //var go = GameObject.FindWithTag("Wall");
        //go.SetActive(false);
    }


    void Update()
    {


    }
}
