using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class UI_PauseMenu : MonoBehaviour
{
    [SerializeField] public GameObject pauseMenu;

    public void pauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void returnGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }
    
}
