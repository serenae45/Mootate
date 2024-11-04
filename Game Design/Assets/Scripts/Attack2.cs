using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack2 : MonoBehaviour
{
    public int damage;
    GameControl health;
    public GameObject Player; 
    public GameObject Animal;   
    List<string> pigEnemies;
    List<string> chickenEnemies;
    List<string> cowEnemies;
    List<string> bunnyEnemies;
    AttackImmunity immunityScript;

    public AudioSource audioSource;
    public AudioClip cow_sound;
    public AudioClip chicken_sound;
    public AudioClip pig_sound;
    public AudioClip bunny_sound;
    public float volume=0.8f;
    bool attack;


    public void Start()
    {
        health = Player.GetComponent<GameControl>();

        SetEnemies setEnemiesScript = Player.GetComponent<SetEnemies>();
        pigEnemies = setEnemiesScript.GetPigEnemies();
        chickenEnemies = setEnemiesScript.GetChickenEnemies();
        cowEnemies = setEnemiesScript.GetCowEnemies();
        bunnyEnemies = setEnemiesScript.GetBunnyEnemies();

        immunityScript = Player.GetComponent<AttackImmunity>();
        attack = immunityScript.GetAttackBool();
        
        //rend = Player.GetComponent<Renderer>();
        //c = rend.material.color;
    }

    void Update()
    {
        float distance = Vector2.Distance(Animal.transform.position, Player.transform.position);
        attack = immunityScript.GetAttackBool();

        if (distance <= 2f)
        {
            AttackPlayer();
        }
    }

    void AttackPlayer()
    {
        if (Animal.tag == "Pig")
        {
            if(pigEnemies.Contains(Player.tag) && attack)
            {
                Debug.Log("Hit");
                audioSource.PlayOneShot(pig_sound, volume);
                health.TakeDamage(1);
                health.gotHit();
                immunityScript.StartCoroutine("Immunity");
            } 
        }
        if (Animal.tag == "Chicken") 
        {
            if(chickenEnemies.Contains(Player.tag) && attack)
            {
                Debug.Log("Hit");
                audioSource.PlayOneShot(chicken_sound, volume);
                health.TakeDamage(1);
                health.gotHit();
                immunityScript.StartCoroutine("Immunity");
            } 
        }
        if (Animal.tag == "Cow") 
        {
            if(cowEnemies.Contains(Player.tag) && attack)
            {
                Debug.Log("Hit");
                audioSource.PlayOneShot(cow_sound, volume);
                health.TakeDamage(1);
                health.gotHit();
                immunityScript.StartCoroutine("Immunity");
            } 
        }
        if (Animal.tag == "Grey Bunny") 
        {
            if(bunnyEnemies.Contains(Player.tag) && attack)
            {
                Debug.Log("Hit");
                audioSource.PlayOneShot(bunny_sound, volume);
                health.TakeDamage(1);
                health.gotHit();
                immunityScript.StartCoroutine("Immunity");
            } 
        }
    }
}    