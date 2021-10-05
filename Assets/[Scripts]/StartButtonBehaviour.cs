// ===============================
// PROGRAM NAME: GAME Programming (T163)
// STUDENT ID : 101206769
// AUTHOR     : AMER ALI MOHAMMED
// CREATE DATE     : SEP 27, 2021
// PURPOSE     : GAME2014_F2021_ASSIGNMENT1
// SPECIAL NOTES:
// ===============================
// Change History:
//
//==================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonBehaviour : MonoBehaviour
{
    public void OnStartButtonPressed()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnInstructionsButtonPressed()
    {
        SceneManager.LoadScene("Instructions");
    }
}
