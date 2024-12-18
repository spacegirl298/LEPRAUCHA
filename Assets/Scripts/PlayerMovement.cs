using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public float horizontalMovement;
    public float verticalMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalAmount = Input.GetAxis("Horizontal") * horizontalMovement * Time.deltaTime;   
        float verticalAmount = Input.GetAxis("Vertical") * verticalMovement * Time.deltaTime;
        transform.Translate(horizontalAmount, verticalAmount, 0); 
    }
}
