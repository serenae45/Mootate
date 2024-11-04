using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : MonoBehaviour
{
    public int damage;
    public GameControl health;
    public GameObject Player;    
    List<string> pigEnemies;
    List<string> chickenEnemies;
    List<string> cowEnemies;
    List<string> bunnyEnemies;
    Renderer rend;
    Color c;
    public int immunityTime;

    public AudioSource audioSource;
    public AudioClip cow_sound;
    public AudioClip chicken_sound;
    public AudioClip pig_sound;
    public AudioClip bunny_sound;
    public float volume=0.8f;


    public void Start()
    {
        SetEnemies setEnemiesScript = gameObject.GetComponent<SetEnemies>();
        pigEnemies = setEnemiesScript.GetPigEnemies();
        chickenEnemies = setEnemiesScript.GetChickenEnemies();
        cowEnemies = setEnemiesScript.GetCowEnemies();
        bunnyEnemies = setEnemiesScript.GetBunnyEnemies();
        rend = GetComponent<Renderer>();
        c = rend.material.color;
    }
  
    private void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.tag == "Pig") 
        {
            Debug.Log("Hit");
            if(pigEnemies.Contains(Player.tag))
            {
                audioSource.PlayOneShot(pig_sound, volume);
                health.TakeDamage(1);
                health.gotHit();
                StartCoroutine("Immunity");
            } 
        }
        if (collision.gameObject.tag == "Chicken") 
        {
            Debug.Log("Hit");
            if(chickenEnemies.Contains(Player.tag))
            {
                audioSource.PlayOneShot(chicken_sound, volume);
                health.TakeDamage(1);
                health.gotHit();
                StartCoroutine("Immunity");
            } 
        }
        if (collision.gameObject.tag == "Cow") 
        {
            Debug.Log("Hit");
            if(cowEnemies.Contains(Player.tag))
            {
                audioSource.PlayOneShot(cow_sound, volume);
                health.TakeDamage(1);
                health.gotHit();
                StartCoroutine("Immunity");
            } 
        }
        if (collision.gameObject.tag == "Grey Bunny") 
        {
            Debug.Log("Hit");
            if(bunnyEnemies.Contains(Player.tag))
            {
                audioSource.PlayOneShot(bunny_sound, volume);
                health.TakeDamage(1);
                health.gotHit();
                StartCoroutine("Immunity");
            } 
        }
    }

    private IEnumerator Immunity() {
        Debug.Log("Coroutine started");
        Physics2D.IgnoreLayerCollision(0, 0, true);
        c.a = 0.5f;
        rend.material.color = c;
        yield return new WaitForSeconds(immunityTime);
        Physics2D.IgnoreLayerCollision(0, 1, false);
        c.a = 1f;
        rend.material.color = c;
        Debug.Log("End of coroutine");
    }
}   

