
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingRandom : MonoBehaviour
{ 
    [SerializeField] float Speed = 10f;
    [SerializeField] float range;
    [SerializeField] float maxDistance;
    public float collisionOffset = 0.05f;
    Vector2 movement;
    public ContactFilter2D movementFilter;
    private List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    public Rigidbody2D rb;
    public Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        SetNewDestination();
    }
 
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, movement, Speed*Time.deltaTime);
        if(Vector2.Distance(transform.position, movement) < range)
        {
            SetNewDestination();
        }
    }

     void SetNewDestination()
    {
        movement = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance,maxDistance));
        if(movement != Vector2.zero)
        {
            bool success = MoveCharacter(movement);
            if(!success)
            {
                success = MoveCharacter(new Vector2(movement.x,0));

                if (!success)
                {
                    success = MoveCharacter(new Vector2(0,movement.y));
                    animator.SetFloat("Horizontal", 0);
                    animator.SetFloat("Vertical", movement.y);
                }
                else
                {
                    animator.SetFloat("Horizontal", movement.x);
                    animator.SetFloat("Vertical", 0);

                }
            }
            else
            {
                animator.SetFloat("Horizontal", movement.x);
                animator.SetFloat("Vertical", movement.y);
            }
        } 
        animator.SetFloat("Speed", movement.sqrMagnitude);     
    }

    public bool MoveCharacter(Vector2 direction)
    {
        int count = rb.Cast(direction, movementFilter, castCollisions, Speed * Time.fixedDeltaTime + collisionOffset);
        if(count == 0)
        {
            Vector2 movePosition = direction * Speed * Time.fixedDeltaTime;
            
            rb.MovePosition(rb.position + movePosition);
            return true;
        }
        else
        {
            foreach (RaycastHit2D hit in castCollisions)
            {
                print(hit.ToString());
            }
            return false;
        }
        
    }
}

