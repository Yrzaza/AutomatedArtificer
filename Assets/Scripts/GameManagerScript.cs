using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject menuButtonToHide;

    public void gameOver()
    {
        //show the gameoverscreen
        gameOverScreen.SetActive(true);
        menuButtonToHide.SetActive(false);
    }
}
