
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AutoMove : MonoBehaviour
{
    /// <summary>
    /// 리스트로 수정할것. 고정배열은 안어울림
    /// </summary>
    public float speed = 1f;
    public float rSpeed = 1f;
    public List<GameObject> targets = new List<GameObject>();
    public List<Renderer> rens = new List<Renderer>();
    public Spawn spawner;
    public float delay = 2f;
    public float timer = 0f;


    //public float limit = 0.1f;
    private Quaternion targetRotation;

    //private Renderer ren;

    public GameObject currTarget;
    public Renderer currRens;

    private void Start()
    {
        GameObject[] targetObjects = GameObject.FindGameObjectsWithTag("Sphere");
        foreach (GameObject obj in targetObjects)
        {
            targets.Add(obj);
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                rens.Add(renderer);
            }
        }
        int curr = Random.Range(0, targets.Count);
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

            if (Vector3.Distance(currTarget.transform.position, transform.position) < 0.3f)
            {
                Destroy(currTarget);
                currTarget = null;
            }
        }
        else
        {
            if (timer >= delay)
            {
                if (!isActive(targets))
                {
                    spawner.Create();
                    GameObject[] targetObjects = GameObject.FindGameObjectsWithTag("Sphere");
                    foreach (GameObject obj in targetObjects)
                    {
                        targets.Add(obj);
                        Renderer renderer = obj.GetComponent<Renderer>();
                        if (renderer != null)
                        {
                            rens.Add(renderer);
                        }
                    }
                }

                int curr = Random.Range(0, targets.Count);
                currTarget = targets[curr];
                currRens = rens[curr];

                if (currTarget != null && currRens != null)
                {
                    currRens.material.color = Color.green;
                }
                timer = 0;
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
    }

    private bool isActive(List<GameObject> list)
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
