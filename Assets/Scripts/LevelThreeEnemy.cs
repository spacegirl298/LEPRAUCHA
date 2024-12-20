using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class LevelThreeEnemy : MonoBehaviour
{
    public Transform[] wayPoints;
    public float moveSpeed = 5f;
    private int wayPointIndex = 0;


    void Start()
    {
        if (wayPoints.Length > 0)
        {
            // Set the object's initial position to the first waypoint
            transform.position = wayPoints[wayPointIndex].transform.position;
        }
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (wayPoints.Length == 0) return; // Exit if no waypoints are assigned

        // Move the object towards the current waypoint
        transform.position = Vector2.MoveTowards(
            transform.position,
            wayPoints[wayPointIndex].transform.position,
            moveSpeed * Time.deltaTime
        );

        // Check if the object has reached the current waypoint
        if (Vector2.Distance(transform.position, wayPoints[wayPointIndex].transform.position) < 0.1f)
        {
            // Move to the next waypoint, looping back to the start if necessary
            wayPointIndex = (wayPointIndex + 1) % wayPoints.Length;
        }
    }


    // Start is called before the first frame update
    /*void Start()
    {
        transform.position = wayPoints[wayPointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        //checks if it has reached last wayPoint
        if (wayPointIndex <= wayPoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, wayPoints[wayPointIndex].transform.position, moveSpeed * Time.deltaTime);

            if (transform.position == wayPoints[wayPointIndex].transform.position)
            {
                wayPointIndex += 1;
            }
        }
    }*/
}
