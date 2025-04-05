using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBallPatrol : MonoBehaviour
{
    [SerializeField] float rotateAngel = 90f;
    [SerializeField] Vector3 pointA;
    [SerializeField] Vector3 pointB;
    Vector3 targetPoint;
    [SerializeField] float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        SetInitialPositions();
    }

    // Update is called once per frame
    void Update()
    {
        RotateSpike();
        SpikePatrolling();
    }

    void RotateSpike()
    {
        transform.Rotate(Vector3.forward, rotateAngel*Time.deltaTime);
    }

    void SpikePatrolling()
    {
       transform.position= Vector3.MoveTowards(transform.position, targetPoint, moveSpeed * Time.deltaTime);
        if (transform.position == targetPoint)
        {
            targetPoint =(targetPoint==pointA) ? pointB: pointA;
        }
    }

    void SetInitialPositions()
    {
        transform.position = pointA;
        targetPoint = pointB;
    }
}
