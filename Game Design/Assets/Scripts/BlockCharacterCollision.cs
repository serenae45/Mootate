using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCharacterCollision : MonoBehaviour
{
    public CircleCollider2D characterCollider;
    //public CircleCollider2D animalCollider;
    public CapsuleCollider2D characterBlockerCollider;


    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(characterCollider, characterBlockerCollider, true);
        //Physics2D.IgnoreCollision(animalCollider, characterBlockerCollider, true);

        
    }

}
