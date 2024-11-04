using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapeshift : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    private Animator animator;
    [SerializeField]
    public AnimatorOverrideController[] overrideControllers;
    public Sprite[] characterList;

    // Cooldown parameters
    //public float cooldown;
    //float lastSwitch = -3;
    //float lastSwitchChicken;
    //float lastSwitchCow;
    //float lastSwitchPig;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            ChangeCharacter();
        } 
    }

    void ChangeCharacter()
    {
        animator = GetComponent<Animator>();
        
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Cooldown
           // if (Time.time - lastSwitch < cooldown) {
            //    return;
            //}
            //lastSwitch = Time.time;
            // End of Cooldown

            gameObject.transform.localScale = new Vector2(1f, 1f);
            spriteRenderer.sprite = characterList[0];
            animator.runtimeAnimatorController = overrideControllers[0]; 
            gameObject.tag = "Pig";

        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {

            gameObject.transform.localScale = new Vector2(1f, 1f);
            spriteRenderer.sprite = characterList[1];
            animator.runtimeAnimatorController = overrideControllers[1];
            gameObject.tag = "Chicken";
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {

            gameObject.transform.localScale = new Vector2(1f, 1f);
            spriteRenderer.sprite = characterList[2];
            animator.runtimeAnimatorController = overrideControllers[2];
            gameObject.tag = "Cow";
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            
            gameObject.transform.localScale = new Vector2(1f, 1f);
            spriteRenderer.sprite = characterList[3];
            animator.runtimeAnimatorController = overrideControllers[3];
            gameObject.tag = "Grey Bunny";
        }
    
        // if(Input.GetKeyDown(KeyCode.Alpha5))
        // {
        //     gameObject.transform.localScale = new Vector2(0.2f, 0.2f);
        //     spriteRenderer.sprite = characterList[4];
        //     animator.runtimeAnimatorController = overrideControllers[4];
        //     gameObject.tag = "Grey Bunny";
        // }
        // if(Input.GetKeyDown(KeyCode.Alpha6))
        // {
        //     //gameObject.transform.localScale = new Vector2(0.2f, 0.2f);
        //     spriteRenderer.sprite = characterList[5];
        //     animator.runtimeAnimatorController = overrideControllers[5];
        //     gameObject.tag = "Pig";
        // }
        // if(Input.GetKeyDown(KeyCode.Alpha7))
        // {
        //    // gameObject.transform.localScale = new Vector2(0.2f, 0.2f);
        //     spriteRenderer.sprite = characterList[6];
        //     animator.runtimeAnimatorController = overrideControllers[6];
        //     gameObject.tag = "Sheep";
        // }

    }
}
