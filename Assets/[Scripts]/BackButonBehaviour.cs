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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BackButonBehaviour : MonoBehaviour
{
    public bool isPaused;
    public GameObject PauseMenu;

    public void OnPausePress()
    {
        
            PauseMenu.SetActive(true);
            Time.timeScale = 0.0f;
     

        //else
        //{
        //    PauseMenu.SetActive(false);
        //    Time.timeScale = 1.0f;
        //}

        //if(Input.GetKeyDown (KeyCode.Escape))
        //{
        //    isPaused = !isPaused;
        //}
    }

    public void OnUnpausePress()
    {
        
            PauseMenu.SetActive(false);
            Time.timeScale = 1.0f;
        
    }
}
