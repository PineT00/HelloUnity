using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject prefeb;

    List<GameObject> goList = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 10; i++)
            {
                var go = Instantiate(prefeb, Random.insideUnitSphere * 10, Random.rotation);
                goList.Add(go);
            }

        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            foreach (GameObject go in goList)
            {
                Destroy(go);
            }
            goList.Clear();
        }

    }
}
