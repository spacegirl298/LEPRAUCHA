using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardEnemy : MonoBehaviour
{
    public int lives = 2;
    // Update is called once per frame
    void Update()
    {
        if (lives == 0 )
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Projectile")
        {
            lives -= 1;
        }
    }
}
