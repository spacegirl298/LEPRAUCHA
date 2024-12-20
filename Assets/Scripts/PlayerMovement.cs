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

    //players
    public GameObject level1Player; 
    public GameObject level2Player; 
    public GameObject level3Player;

    //Health
    public GameObject[] Lives;
    public int life = 4;

    //Level 1
    public GameObject Level1Text;
    public bool Level1True;

    //Level 1 to Level 2
    public GameObject[] Enemies;
    public GameObject Level2text;
    public GameObject Level2Enemies;
    public bool Level2True;

    //Level2 to Level 3
    public GameObject[] level2Enemies;
    public GameObject level3text;
    public GameObject level3Enemies;
    public GameObject[] Level3Enemies;
    public bool Level3True;

    //Win
    public GameObject WinScreen;
    public PauseButton PauseButton;

    private void Start()
    {
        level1Player.SetActive(true);
        Level1Text.SetActive(true);

        Level2text.SetActive(false);
        Level2Enemies.SetActive(false);
        level2Player.SetActive(false);

        level3Enemies.SetActive(false) ;
        level3text.SetActive(false);
        level3Player.SetActive(false) ; 

        WinScreen.SetActive(false);

        /*Level1True = true;
        Level2True = false;
        Level3True = false;*/
        
    }
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

        float horizontalAmount = Input.GetAxis("Horizontal") * horizontalMovement * Time.deltaTime;   
        float verticalAmount = Input.GetAxis("Vertical") * verticalMovement * Time.deltaTime;
        transform.Translate(horizontalAmount, verticalAmount, 0);
        

        if (Enemies.All(obj => obj == null)) //Starts Level 2
        {
            level1Player.SetActive(false);
            Level1Text.SetActive(false);

            Level2Enemies.SetActive(true);
            Level2text.SetActive(true);
            level2Player.SetActive(true);

         /*  Level1True = false;
            Level2True = true;*/

        }

        if (level2Enemies.All(obj => obj == null)) //Starts Level 3
        {
            Level2text.SetActive(false);
            level2Player.SetActive(false);

            level3Enemies.SetActive(true);
            level3text.SetActive(true);
            level3Player.SetActive(true);

            /*Level2True = false;
            Level3True = true;*/
           
        }

        if (Level3Enemies.All(obj => obj == null))
        {
            WinScreen.SetActive(true);
            level3Player.SetActive(false);
            PauseButton.Pause.SetActive(false);

        }
    }

    public void OnTriggerEnter2D(Collider2D collision) //this will be for losing lives 
    {
        if (collision.tag == "Enemy")
        {
            // Destroy(gameObject);
            life--;
            transform.position = new Vector2(0, -4.0563f);
        }

        if (collision.tag == "HardEnemy")
        {
            //Destroy(gameObject);
            life--;
            transform.position = new Vector2(0, -4.0563f);
        }

        if (collision.gameObject.CompareTag("EnemyProjectile"))
        {
            life--;
            transform.position = new Vector2(0, -4.0563f);
        }
    }
}

