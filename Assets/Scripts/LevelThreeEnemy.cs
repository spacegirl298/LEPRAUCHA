using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class LevelThreeEnemy : MonoBehaviour
{
    public Transform[] wayPoints;
    public float moveSpeed = 5f;
    private int wayPointIndex = 0;

    // Start is called before the first frame update
    void Start()
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
    }
}
