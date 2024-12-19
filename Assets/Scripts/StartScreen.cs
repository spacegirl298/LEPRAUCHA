using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public GameObject Controls;

    public void StartButton()
    {
        SceneManager.LoadScene("Leprechaun");
    }

    public void ControlsButton()
    {
        Controls.SetActive(true);
    }

    public void ExitControls()
    {
        Controls.SetActive(false); 
    }
}

