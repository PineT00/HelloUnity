using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject prefeb;

    List<GameObject> goList = new List<GameObject>();


    private void Awake()
    {
        Create();
    }

    private void Start()
    {
        
    }

    void Update()
    {

    }

    public void Create()
    {
        for (int i = 0; i < 5; i++)
        {
            var go = Instantiate(prefeb, Random.insideUnitSphere * 10, Random.rotation);
            goList.Add(go);
        }
    }

}
