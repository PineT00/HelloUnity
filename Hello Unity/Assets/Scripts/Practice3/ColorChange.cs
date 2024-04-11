using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ColorChange : MonoBehaviour
{
    public GameObject[] targets;
    public Renderer[] rens;

    public Color startColor = Color.black;
    public Color endColor = Color.white;

    [Range(0f, 1f)]
    public float colorT = 0f;

    public float maxDistance = 10f;
    public float minDistance = 0f;

    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Sphere");
        rens = new Renderer[targets.Length];

        for(int i = 0; i < targets.Length; ++i)
        {
            rens[i] = targets[i].GetComponent<Renderer>();
        }
    }

    void Update()
    {
        for (int i = 0; i < targets.Length; i++)
        {
            var distance = Vector3.Distance(targets[i].transform.position, transform.position);
            colorT = Mathf.Clamp01((distance - minDistance) / (maxDistance - minDistance));
            //colorT = distance / 10;
            rens[i].material.color = Color.Lerp(startColor, endColor, colorT);
        }
    }
}
