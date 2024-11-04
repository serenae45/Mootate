using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkingText : MonoBehaviour
{
    public Text text;
    public float timeValue = 120;
    private int minuteFlash = 0;

    public AudioSource audioSource;
    public AudioClip ticking_sound2;
    public AudioClip ticking_sound1;
    public float volume=3.0f;


    private void Start()
    {
        text = GetComponent<Text>();
    }


    IEnumerator Blink()
    {
        while (true)
        {
            switch (text.color.a.ToString())
            {
                case "0":
                    text.color = new Color(text.color.r, text.color.g, text.color.b, 1);
                    yield return new WaitForSeconds(0.5f);
                    break;
                case "1":
                    text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
                    yield return new WaitForSeconds(0.5f);
                    break;
            }

        }

    }

    void StartBlinking()
    {
        StartCoroutine("Blink");
    }

    void StopBlinking()
    {
        StopCoroutine("Blink");
    }


       // Update is called once per frame
    void Update()
    {
        if (timeValue > 0){
            timeValue -= Time.deltaTime;
        }
        else {
            timeValue = 0;
        }

        if ((int)timeValue == 60 && minuteFlash == 0)
        {
            audioSource.PlayOneShot(ticking_sound1, 4.0f);
            StartBlinking();
            minuteFlash = minuteFlash + 1;
        }
        if ((int)timeValue == 10 && minuteFlash == 2)
        {
            audioSource.PlayOneShot(ticking_sound2, volume);
            StartBlinking();
            minuteFlash = minuteFlash + 1;
        }
        if ((int)timeValue == 57 && minuteFlash == 1 || (int)timeValue == 0 && minuteFlash == 3)
        {
            StopBlinking();
            minuteFlash = minuteFlash + 1;
        }
    }

 
}
