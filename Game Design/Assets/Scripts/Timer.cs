using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Timer : MonoBehaviour
{
    public float timeValue = 90;
    public Text timeText;
    public static event Action OnPlayerDeath;
    int invoke = 0;


    void Update() {
        if (timeValue > 0){
            timeValue -= Time.deltaTime;
        }
        else {
            timeValue = 0;
        }

        DisplayTime(timeValue);

    }

    void DisplayTime(float timeToDisplay) {
        if(timeToDisplay < 0) {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (timeValue == 0 && invoke == 0) {
            OnPlayerDeath?.Invoke();
            invoke += 1;
        }
    }

}