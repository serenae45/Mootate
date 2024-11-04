using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class WinCondition : MonoBehaviour
{
    public GameObject Player;
    public static event Action OnPlayerWin;

    public AudioSource audioSource;
    public AudioClip win_sound;
    public float volume=0.5f;
    private int play_once = 0;

    float timeValue = 3;
    private int numRuns = 0;

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject == Player && play_once == 0){
            Debug.Log("You Win!");
            audioSource.Stop();
            audioSource.PlayOneShot(win_sound, volume);
            play_once +=1;
        }
    }

    void Update()
    {
        if (play_once == 1){
            if (timeValue > 0){
                timeValue -= Time.deltaTime;
            }
            else {
                timeValue = 0;
            }

            if ((int)timeValue == 0 && numRuns == 0) {
                // invoke the game over screen
                audioSource.Stop();
                OnPlayerWin?.Invoke();
                numRuns =+1;
            }
        }
        
    }
}
