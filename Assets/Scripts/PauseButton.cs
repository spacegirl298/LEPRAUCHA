using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    public GameObject PauseScreen;
    public GameObject Pause;
   /* public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;*/

    public PlayerMovement PlayerMovement;
    public void Start()
    {
        PauseScreen.SetActive(false);
        Pause.SetActive(true);

    }

    public void PauseButtn()
    {
        PauseScreen.SetActive(true);
        Pause.SetActive(false);

       /* if (Player1 != null)
        {
            Player1.SetActive(false);
        }
        else if (Player2 != null)
        {
            Player2.SetActive(false);
        }
        else if (Player3 != null)
        {
            Player3.SetActive(false);
        }*/
        
    }

    public void PlayButton()
    {
        PauseScreen.SetActive(false);
        Pause.SetActive(true);

        /*if (PlayerMovement.Level1True == true)
        {
            Player1.SetActive(true);
        }
        else if (PlayerMovement.Level2True == true)
        {
            Player2.SetActive(true);
        }
        else if (PlayerMovement.Level3True == true) 
        {
            Player3.SetActive(true);
        }*/
    }

    public void Restart()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
