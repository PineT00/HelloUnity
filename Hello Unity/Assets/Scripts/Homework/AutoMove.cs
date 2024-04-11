using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AutoMove : MonoBehaviour
{
    public float speed = 1f;
    public float rSpeed = 1f;
    public GameObject[] targets;
    public Renderer[] rens;
    public Spawn spawner;
    public float delay = 3f;
    public float timer = 0f;


    //public float limit = 0.1f;
    private Quaternion targetRotation;

    //private Renderer ren;

    public GameObject currTarget;
    public Renderer currRens;

    private void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("Sphere");
        rens = new Renderer[targets.Length];
        for (int i = 0; i < targets.Length; ++i)
        {
            rens[i] = targets[i].GetComponent<Renderer>();
        }
        int curr = Random.Range(0, targets.Length);
        currTarget = targets[curr];
        currRens = rens[curr];
        currRens.material.color = Color.green;
    }

    private void Update()
    {
        var direction = Vector3.zero;
        if (currTarget != null)
        {
            direction = currTarget.transform.position - transform.position;
            direction.Normalize();
            targetRotation = Quaternion.LookRotation(direction);

            transform.position = Vector3.Lerp(transform.position, currTarget.transform.position, Time.deltaTime * speed);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * speed);

            if(Vector3.Distance(currTarget.transform.position, transform.position) < 0.3f)
            {
                Destroy(currTarget);
            }
        }
        else
        {
            if(timer > delay)
            {
                if (!isActive(targets))
                {
                    spawner.Create();
                    targets = GameObject.FindGameObjectsWithTag("Sphere");
                    rens = new Renderer[targets.Length];
                    for (int i = 0; i < targets.Length; ++i)
                    {
                        rens[i] = targets[i].GetComponent<Renderer>();
                    }
                }

                int curr = Random.Range(0, targets.Length);
                currTarget = targets[curr];
                currRens = rens[curr];
                currRens.material.color = Color.green;

                timer = 0;
            }
            else
            {
                timer += Time.deltaTime;
            }

        }


    }

    private bool isActive(GameObject[] list)
    {
        foreach (GameObject target in list)
        {
            if (target != null && target.activeSelf)
            {
                return true;
            }
        }
        return false;
    }
}
