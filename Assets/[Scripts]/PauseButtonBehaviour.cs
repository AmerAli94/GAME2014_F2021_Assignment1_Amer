// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : SEP 27, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT1
// SPECIAL NOTES:
// ===============================
// Change History:
// Added Enemy Spawns and File Headers for the project
//==================================
// Change History:
// Added Quit and Menu Buttons
//==================================


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseButtonBehaviour : MonoBehaviour
{
    public bool isPaused;
    public GameObject PauseMenu;

    public void OnPausePress()
    {
        
            PauseMenu.SetActive(true);
            Time.timeScale = 0.0f;
    }

    public void OnUnpausePress()
    {
        
            PauseMenu.SetActive(false);
            Time.timeScale = 1.0f;
        
    }

    public void OnQuitPress()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();

    }


    public void OnMenuPressed()
    {
        SceneManager.LoadScene("Menu");

    }
}

