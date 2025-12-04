using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class UI_Exit_Button : MonoBehaviour
{

    public void buttonExitGame()
    {
        // quit the fuckin game
        Application.Quit();

        //make sure game is quit
        Debug.Log("We leavin the game");

        }
    public void RestartGame()
    {
        //reload the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //make sure game is reload
        Debug.Log("We reloadin");
        //unpause the timer
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }

}
