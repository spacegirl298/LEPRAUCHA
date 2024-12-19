using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //Movement
    public float movementSpeed;
    public float horizontalMovement;
    public float verticalMovement;

    //Health
    public GameObject[] Lives;
    public int life = 4;

    //Level 1 to Level 2
    public GameObject[] Enemies;
    public GameObject Level2text;
    public GameObject Level2Enemies;

    private void Start()
    {
        Level2text.SetActive(false);
        Level2Enemies.SetActive(false);
    }
    void Update()
    {
        float horizontalAmount = Input.GetAxis("Horizontal") * horizontalMovement * Time.deltaTime;   
        float verticalAmount = Input.GetAxis("Vertical") * verticalMovement * Time.deltaTime;
        transform.Translate(horizontalAmount, verticalAmount, 0);
        //health system
        if (life < 1)
        {
            Destroy(Lives[0].gameObject);
        }
        else if (life < 2)
        {
            Destroy(Lives[1].gameObject);
        }
        else if (life < 3)
        {
            Destroy(Lives[2].gameObject);
        }

        if(life ==0)
        {
            Debug.Log("death");
            SceneManager.LoadScene("StartScreen");
        }

        if (Enemies.All(obj => obj == null)) //Starts Level 2
        {
            Level2Enemies.SetActive(true);
            Level2text.SetActive(true);
            transform.position = new Vector2(-0.5286f, -4.0563f);
        }


    }

    public void OnTriggerEnter2D(Collider2D collision) //this will be for losing lives 
    {
        if(collision.tag == "Enemy")
        {
           // Destroy(gameObject);
            life--;
            transform.position = new Vector2(-0.5286f, -4.0563f);
        }

        if (collision.tag == "HardEnemy")
        {
            //Destroy(gameObject);
            life--;
            transform.position = new Vector2(-0.5286f, -4.0563f);
        }
    }

    
}
