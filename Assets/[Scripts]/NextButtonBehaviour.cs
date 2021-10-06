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


public class NextButtonBehaviour : MonoBehaviour
{
    public void OnNextButtonPressed()
    {
        SceneManager.LoadScene("End");
    }
}
