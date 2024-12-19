using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
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
    // Start is called before the first frame update
    void Start()
    {
        Level2text.SetActive(false);
        Level2Enemies.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
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

        if (life == 0)
        {
            Debug.Log("death");
            SceneManager.LoadScene("StartScreen");
        }

        if (Enemies.All(obj => obj == null)) //Starts Level 2
        {   
            Level2Enemies.SetActive(true);
            Level2text.SetActive(true);
            transform.position = new Vector2(-0.5286f, -4.0563f);
            float horizontalAmount = Input.GetAxis("Horizontal") * horizontalMovement * Time.deltaTime;
            float verticalAmount = Input.GetAxis("Vertical") * verticalMovement * Time.deltaTime;
            transform.Translate(horizontalAmount, verticalAmount, 0);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
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


        if (collision.gameObject.CompareTag("EnemyProjectile"))
        {
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

            if (life == 0)
            {
                Debug.Log("death");
                SceneManager.LoadScene("StartScreen");
            }
        }

    }
   
}

