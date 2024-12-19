using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMovemnt : MonoBehaviour
{
    public int moveSpeed = 5;
    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime); // movement 

        if(transform.position.y <= 2f ) 
        {
            transform.position = new Vector2(transform.position.x, transform.position.y +2);    
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        
        if (collision.tag == "Boundary")
        {
            moveSpeed *= -1; //changes to the opposite horizontal movement 
            transform.position = new Vector2(transform.position.x, transform.position.y -1); // goes down 
        }
       
    }
}
