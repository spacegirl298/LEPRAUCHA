using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovemnt : MonoBehaviour
{
    public int moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boundary")
        {
            moveSpeed *= -1;
            transform.position = new Vector2(transform.position.x, transform.position.y -1);
        }
    }
}
