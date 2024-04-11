using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRotate : MonoBehaviour
{
    public Color startColor = Color.red;
    public Color endColor = Color.blue;

    [Range(0f, 1f)]
    public float colorT = 0f;

    public float speed = 1f;
    public float rSpeed = 1f;
    public Transform target;
    public float limit = 0.1f;
    private Quaternion targetRotation;

    private Renderer ren;


    private void Start()
    {
        ren = GetComponent<Renderer>();
    }

    private void Update()
    {
        ren.material.color = Color.Lerp(startColor, endColor, colorT);

        var direction = Vector3.zero;
        if (target != null)
        {
            if (Vector2.Distance(target.position, transform.position) < limit)
            {
                colorT = 0.3f;
                //transform.position = target.position;
            }
            else
            {
                colorT = 1f;
                direction = target.position - transform.position;
                direction.Normalize();
                targetRotation = Quaternion.LookRotation(direction);

                transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rSpeed);
            }

        }



        //transform.position += direction * speed * Time.deltaTime;
        //transform.position += transform.right * speed * Time.deltaTime;
        //transform.position += transform.up * speed * Time.deltaTime;
        //transform.position += -transform.right * speed * Time.deltaTime;
    }
}
