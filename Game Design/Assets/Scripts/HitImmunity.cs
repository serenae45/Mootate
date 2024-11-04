using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class HitImmunity : MonoBehaviour
{
    Renderer rend;
    Color c;
    public GameControl GameControl;

    void Start() {
        rend = GetComponent<Renderer>();
        c = rend.material.color;
    }

    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Pig" && GameControl.health > 0 ) {
            Debug.Log("Immunity");
            StartCoroutine("Immunity");
        }

        if (collision.gameObject.tag == "Chicken" && GameControl.health > 0 ) {
            Debug.Log("Immunity");
            StartCoroutine("Immunity");
        }

        if (collision.gameObject.tag == "Cow" && GameControl.health > 0 ) {
            Debug.Log("Immunity");
            StartCoroutine("Immunity");
        }

        if (collision.gameObject.tag == "Grey Bunny" && GameControl.health > 0 ) {
            Debug.Log("Immunity");
            StartCoroutine("Immunity");
        }
    }

    IEnumerator Immunity() {
        Debug.Log("Coroutine started");
        Physics2D.IgnoreLayerCollision(0, 0, true);
        c.a = 0.5f;
        rend.material.color = c;
        yield return new WaitForSeconds(10);
        Physics2D.IgnoreLayerCollision(0, 0, false);
        c.a = 1f;
        rend.material.color = c;
    }
}
