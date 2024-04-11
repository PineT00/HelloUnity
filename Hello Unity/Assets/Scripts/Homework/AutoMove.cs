using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AutoMove : MonoBehaviour
{
    public float speed = 1f;
    public float rSpeed = 1f;
    public GameObject[] targets;
    public Renderer[] rens;

    //public float limit = 0.1f;
    private Quaternion targetRotation;

    //private Renderer ren;

    public GameObject currTarget;

    private void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Sphere");
        rens = new Renderer[targets.Length];

        for (int i = 0; i < targets.Length; ++i)
        {
            rens[i] = targets[i].GetComponent<Renderer>();
        }
    }

    private void Update()
    {
        var direction = Vector3.zero;
        if (targets != null)
        {

            direction = currTarget.transform.position - transform.position;
            direction.Normalize();
            targetRotation = Quaternion.LookRotation(direction);

            transform.position = Vector3.Lerp(transform.position, currTarget.transform.position, Time.deltaTime * speed);
        }
        else
        {
            for (int i = 0; i < targets.Length; ++i)
            {
                float near = Vector3.Distance(targets[i].transform.position, transform.position);
                //자동추적 목표설정중
            }
        }
    }
}
