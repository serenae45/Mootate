using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject GameOverMenu;
    public GameObject YouWinMenu;

    public AudioSource audioSource;
    public AudioClip lose_sound;
    public float volume=0.8f;

    private void OnEnable(){
        GameControl.OnPlayerDeath += EnableLossGameOverMenu;
        Timer.OnPlayerDeath += EnableLossGameOverMenu;
        WinCondition.OnPlayerWin += EnableWinGameOverMenu;
    }

    private void OnDisable() {
        GameControl.OnPlayerDeath -= EnableLossGameOverMenu;
        Timer.OnPlayerDeath -= EnableLossGameOverMenu;
        WinCondition.OnPlayerWin -= EnableWinGameOverMenu;
    }

    public void EnableLossGameOverMenu() {
        audioSource.Stop();
        audioSource.PlayOneShot(lose_sound, 0.8f);
        Time.timeScale = 0f;
        GameOverMenu.SetActive(true);

    }

    public void EnableWinGameOverMenu() {
        Time.timeScale = 0f;
        YouWinMenu.SetActive(true);
    }
    

    public void PlayAgain() {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }

}
