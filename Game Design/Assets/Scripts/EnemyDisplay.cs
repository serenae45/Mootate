using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyDisplay : MonoBehaviour
{
    public Sprite[] characterList;
    //public SpriteRenderer Enemy_1;
    //public SpriteRenderer Enemy_2;
    public GameObject Animal;
    public GameObject Player;
    List<string> pigEnemies;
    List<string> chickenEnemies;
    List<string> cowEnemies;
    List<string> bunnyEnemies;

    public Image Enemy_1;
    public Image Enemy_2;

    
    
    private List<string> Animals = new List<string>();    
    
    // Start is called before the first frame update
    public void Start()
    {
        SetEnemies setEnemiesScript = Player.GetComponent<SetEnemies>();

        pigEnemies = setEnemiesScript.GetPigEnemies();
        chickenEnemies = setEnemiesScript.GetChickenEnemies();
        cowEnemies = setEnemiesScript.GetCowEnemies();
        bunnyEnemies = setEnemiesScript.GetBunnyEnemies();

        SetAnimalList();   
        SetDisplay();
    }

    void SetDisplay()
    {
        if(Animal.tag == "Pig")
        {
            int index_1 = Animals.IndexOf(pigEnemies[0]);
            int index_2 = Animals.IndexOf(pigEnemies[1]);


            Enemy_1.sprite = characterList[index_1];
            Enemy_2.sprite = characterList[index_2];
        }
        else if(Animal.tag == "Chicken")
        {
            int index_1 = Animals.IndexOf(chickenEnemies[0]);
            int index_2 = Animals.IndexOf(chickenEnemies[1]);

            Enemy_1.sprite = characterList[index_1];
            Enemy_2.sprite = characterList[index_2];
        }
        else if(Animal.tag == "Cow")
        {
            int index_1 = Animals.IndexOf(cowEnemies[0]);
            int index_2 = Animals.IndexOf(cowEnemies[1]);

            Enemy_1.sprite = characterList[index_1];
            Enemy_2.sprite = characterList[index_2];
        }
        else if(Animal.tag == "Grey Bunny")
        {
            int index_1 = Animals.IndexOf(bunnyEnemies[0]);
            int index_2 = Animals.IndexOf(bunnyEnemies[1]);

            Enemy_1.sprite = characterList[index_1];
            Enemy_2.sprite = characterList[index_2];
        }
    }
    void SetAnimalList()
    {
        Animals.Add("Pig");
        Animals.Add("Chicken");
        Animals.Add("Cow");
        Animals.Add("Grey Bunny");
    }

}
