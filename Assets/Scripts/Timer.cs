using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if(remainingTime<0)
        {
            remainingTime = 0;
            //game end state
            timerText.color = Color.red;
        }

        //div time into minutes
        int minutes = Mathf.FloorToInt(remainingTime/60);
        // minutes into seconds
        int seconds = Mathf.FloorToInt(remainingTime%60);
        //string output minute+seconds
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);


    }

}
