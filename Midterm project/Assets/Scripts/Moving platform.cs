using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovingPlatform : MonoBehaviour
{
    public Transform targetA; // Transform of the starting point.
    public Transform targetB; // Transform of the ending point.
    public float speed = 4.0f;

    private Vector3 currentTarget;

    private void Start()
    {
        currentTarget = targetB.position;
    }

    private void Update()
    {
        // Move the platform towards the current target.
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

        // If the platform reaches the target, switch the target.
        if (Vector3.Distance(transform.position, currentTarget) < 0.1f)
        {
            currentTarget = (currentTarget == targetA.position)  ? targetB.position : targetA.position;
        }
    }
}
