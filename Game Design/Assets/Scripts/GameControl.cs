using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GameControl : MonoBehaviour
{
    public GameObject life3, life2, life1, life3x, life2x, life1x, hitPanel;
    public int health;
    public static event Action OnPlayerDeath;

    void Start()
    {
        health = 3;
        life3.gameObject.SetActive(true);
        life2.gameObject.SetActive(true);
        life1.gameObject.SetActive(true);

        life3x.gameObject.SetActive(false);
        life2x.gameObject.SetActive(false);
        life1x.gameObject.SetActive(false);
    }

    public void TakeDamage(int damage) {
        health -= damage;
        if (health == 3) {
            life3.gameObject.SetActive(true);
            life2.gameObject.SetActive(true);
            life1.gameObject.SetActive(true);

            life3x.gameObject.SetActive(false);
            life2x.gameObject.SetActive(false);
            life1x.gameObject.SetActive(false);
        }
        if (health == 2) {
            life3.gameObject.SetActive(true);
            life2.gameObject.SetActive(true);
            life1.gameObject.SetActive(false);

            life3x.gameObject.SetActive(false);
            life2x.gameObject.SetActive(false);
            life1x.gameObject.SetActive(true);
        }
        if (health == 1) {
            life3.gameObject.SetActive(true);
            life2.gameObject.SetActive(false);
            life1.gameObject.SetActive(false);

            life3x.gameObject.SetActive(false);
            life2x.gameObject.SetActive(true);
            life1x.gameObject.SetActive(true);
        }
        if (health == 0) {
            life3.gameObject.SetActive(false);
            life2.gameObject.SetActive(false);
            life1.gameObject.SetActive(false);

            life3x.gameObject.SetActive(true);
            life2x.gameObject.SetActive(true);
            life1x.gameObject.SetActive(true);

            OnPlayerDeath?.Invoke();
        }
    }

    public void gotHit() {
        var color = hitPanel.GetComponent<Image>().color;
        color.a = 0.75f;

        hitPanel.GetComponent<Image>().color = color;
    }

    void Update() {
        if (hitPanel != null) {
            if (hitPanel.GetComponent<Image>().color.a > 0) {
                var color = hitPanel.GetComponent<Image>().color;
                color.a -= 0.01f;

                hitPanel.GetComponent<Image>().color = color;
            }
        }
    }
}
