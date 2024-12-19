using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject projectile;
    
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, transform.position, Quaternion.identity);  
        }
    }
}
