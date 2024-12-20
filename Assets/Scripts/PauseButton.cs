using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    public GameObject PauseScreen;
    public GameObject Pause;

    public void Start()
    {
        PauseScreen.SetActive(false);
        Pause.SetActive(true);
    }

    public void PauseButtn()
    {
        PauseScreen.SetActive(true);
        Pause.SetActive(false);
    }

    public void PlayButton()
    {
        PauseScreen.SetActive(false);
        Pause.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("StartScreen");
    }
}
