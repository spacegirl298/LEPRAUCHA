using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardEnemy : MonoBehaviour
{
    public float lives = 2;

    void Update()
    {
        if (lives == 0 )
        {
            Destroy(gameObject);
            Debug.Log("destroyed");
        }
    }

    public void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Projectile")) 
        {
            lives--;
            Debug.Log("projectile hit");
        }
    }
}
