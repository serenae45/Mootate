using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class SetEnemies : MonoBehaviour
{
    private List<string> pigEnemies = new List<string>();
    private List<string> chickenEnemies = new List<string>();
    private List<string> cowEnemies = new List<string>();
    private List<string> bunnyEnemies = new List<string>();

    public List<List<string>> enemyOptions = new List<List<string>>();

    // Start is called before the first frame update
    public void Awake()
    {
        pigEnemies.Clear();
        chickenEnemies.Clear();
        cowEnemies.Clear();
        bunnyEnemies.Clear();

        int index = RandomNumber();

        SetEnemyOptions();

        Debug.Log(index.ToString());

        List<string> enemyList = new List<string>();

        foreach (string word in enemyOptions[index])
        {
            enemyList.Add(word);
        }
        
        SetPigEnemies(enemyList);
        SetChickenEnemies(enemyList);
        SetCowEnemies(enemyList);
        SetBunnyEnemies(enemyList);
    }
    public int RandomNumber()
    {
        int num = Random.Range(0,24);
        return num;
    }

    private void SetPigEnemies(List<string> enemyList)
    {      
        pigEnemies.Add(enemyList[0]);
        pigEnemies.Add(enemyList[4]);
        pigEnemies.Add("Player"); 
        
        Debug.Log("Pig enemy 1:" + pigEnemies[0].ToString());
        Debug.Log("Pig enemy 2:" + pigEnemies[1].ToString());
    }
    private void SetChickenEnemies(List<string> enemyList)
    {        
        chickenEnemies.Add(enemyList[1]);
        chickenEnemies.Add(enemyList[5]);
        chickenEnemies.Add("Player"); 
        
        Debug.Log("Chicken enemy 1:" + chickenEnemies[0].ToString());
        Debug.Log("Chicken enemy 2:" + chickenEnemies[1].ToString());
    }
    private void SetCowEnemies(List<string> enemyList)
    {        
        cowEnemies.Add(enemyList[2]);
        cowEnemies.Add(enemyList[6]);
        cowEnemies.Add("Player");    

        Debug.Log("Cow enemy 1:" + cowEnemies[0].ToString());
        Debug.Log("Cow enemy 2:" + cowEnemies[1].ToString());
    }

    private void SetBunnyEnemies(List<string> enemyList)
    {        
        bunnyEnemies.Add(enemyList[3]);
        bunnyEnemies.Add(enemyList[7]);
        bunnyEnemies.Add("Player");   
              
        Debug.Log("Bunny enemy 1:" + bunnyEnemies[0].ToString());
        Debug.Log("Bunny enemy 2:" + bunnyEnemies[1].ToString());
    }
    
    public List<string> GetPigEnemies()
    {
        return pigEnemies;
    }
    public List<string> GetChickenEnemies()
    {
        return chickenEnemies;
    }
    public List<string> GetCowEnemies()
    {
        return cowEnemies;
    }
    public List<string> GetBunnyEnemies()
    {
        return bunnyEnemies;
    }

    public void SetEnemyOptions()
    {
        List<string> option1 = new List<string> {"Chicken", "Cow", "Grey Bunny", "Pig",
                                "Cow", "Grey Bunny", "Pig", "Chicken"};
        
        enemyOptions.Add(new List<string>());
        foreach (string word in option1)
        {
            enemyOptions[0].Add(word);
        }

        List<string> option2 = new List<string> {"Chicken", "Cow", "Grey Bunny", "Pig",
                                "Grey Bunny", "Pig", "Chicken", "Cow"};

        enemyOptions.Add(new List<string>());
        foreach (string word in option2)
        {
            enemyOptions[1].Add(word);
        }

        List<string> option3 = new List<string> {"Chicken", "Grey Bunny", "Pig", "Cow",
                                "Cow", "Pig", "Grey Bunny", "Chicken"};

        enemyOptions.Add(new List<string>());
        foreach (string word in option3)
        {
            enemyOptions[2].Add(word);
        }

        List<string> option4 = new List<string> {"Chicken", "Grey Bunny", "Pig", "Cow",
                                "Grey Bunny", "Cow", "Chicken", "Pig"};

        enemyOptions.Add(new List<string>());
        foreach (string word in option4)
        {
            enemyOptions[3].Add(word);
        }                        

        List<string> option5 = new List<string> {"Chicken", "Pig", "Grey Bunny", "Cow",
                                "Cow", "Grey Bunny", "Pig", "Chicken"};

        enemyOptions.Add(new List<string>());
        foreach (string word in option5)
        {
            enemyOptions[4].Add(word);
        }

        List<string> option6 = new List<string> {"Chicken", "Pig", "Grey Bunny", "Cow",
                                "Cow", "Grey Bunny", "Chicken", "Pig"};
        
        enemyOptions.Add(new List<string>());
        foreach (string word in option6)
        {
            enemyOptions[5].Add(word);
        }

        List<string> option7 = new List<string> {"Chicken", "Pig", "Grey Bunny", "Cow",
                                "Grey Bunny", "Cow", "Chicken", "Pig"};
        enemyOptions.Add(option7);

        List<string> option8 = new List<string> {"Chicken", "Pig", "Grey Bunny", "Cow",
                                "Grey Bunny", "Cow", "Pig", "Chicken"};
        enemyOptions.Add(option8);

        List<string> option9 = new List<string> {"Cow", "Pig", "Grey Bunny", "Chicken",
                                "Chicken", "Grey Bunny", "Pig", "Cow"};
        enemyOptions.Add(option9);

        List<string> option10 = new List<string> {"Cow", "Pig", "Grey Bunny", "Chicken",
                                "Grey Bunny", "Cow", "Chicken", "Pig"};
        enemyOptions.Add(option10);

        List<string> option11 = new List<string> {"Cow", "Grey Bunny", "Pig", "Chicken",
                                "Chicken", "Cow", "Grey Bunny", "Pig"};
        enemyOptions.Add(option11);

        List<string> option12 = new List<string> {"Cow", "Grey Bunny", "Pig", "Chicken",
                                "Chicken", "Pig", "Grey Bunny", "Cow"};
        enemyOptions.Add(option12);

        List<string> option13 = new List<string> {"Cow", "Grey Bunny", "Pig", "Chicken",
                                "Grey Bunny", "Cow", "Chicken", "Pig"};
        enemyOptions.Add(option13);

        List<string> option14 = new List<string> {"Cow", "Grey Bunny", "Pig", "Chicken",
                                "Grey Bunny", "Pig", "Chicken", "Cow"};
        enemyOptions.Add(option14);

        List<string> option15 = new List<string> {"Cow", "Grey Bunny", "Chicken", "Pig",
                                "Chicken", "Pig", "Grey Bunny", "Cow"};
        enemyOptions.Add(option15);

        List<string> option16 = new List<string> {"Cow", "Grey Bunny", "Chicken", "Pig",
                                "Grey Bunny", "Cow", "Pig", "Chicken"};
        enemyOptions.Add(option16);

        List<string> option17 = new List<string> {"Grey Bunny", "Cow", "Chicken", "Pig",
                                "Chicken", "Grey Bunny", "Pig", "Cow"};
        enemyOptions.Add(option17);

        List<string> option18 = new List<string> {"Grey Bunny", "Cow", "Chicken", "Pig",
                                "Chicken", "Pig", "Grey Bunny", "Cow"};
        enemyOptions.Add(option18);

        List<string> option19 = new List<string> {"Grey Bunny", "Cow", "Chicken", "Pig",
                                "Cow", "Pig", "Grey Bunny", "Chicken"};
        enemyOptions.Add(option19);

        List<string> option20 = new List<string> {"Grey Bunny", "Cow", "Chicken", "Pig",
                                "Cow", "Grey Bunny", "Pig", "Chicken"};
        enemyOptions.Add(option20);

        List<string> option21 = new List<string> {"Grey Bunny", "Cow", "Pig", "Chicken",
                                "Chicken", "Pig", "Grey Bunny", "Cow"};
        enemyOptions.Add(option21);

        List<string> option22 = new List<string> {"Grey Bunny", "Cow", "Pig", "Chicken",
                                "Cow", "Grey Bunny", "Chicken", "Pig"};
        enemyOptions.Add(option22);

        List<string> option23 = new List<string> {"Grey Bunny", "Pig", "Chicken", "Cow",
                                "Chicken", "Cow", "Grey Bunny", "Pig"};
        enemyOptions.Add(option23);

        List<string> option24 = new List<string> {"Grey Bunny", "Pig", "Chicken", "Cow",
                                "Cow", "Grey Bunny", "Pig", "Chicken"};
        enemyOptions.Add(option24);
    }
}

