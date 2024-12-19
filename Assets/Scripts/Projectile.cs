using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float moveSpeed;

    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) // destroys the enemies 
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);    
        }

        if (collision.gameObject.CompareTag("HardEnemy"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Boundary")) //destroys the projectiles once it hits the boundary
        {
            Destroy(gameObject);    
        }
    }
}
