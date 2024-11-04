using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_controller : MonoBehaviour
{
    public float moveSpeed = 100f;
    public float collisionOffset = 0.05f;
    public ContactFilter2D movementFilter;

    private Vector2 moveInput;
    private List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();
    private Rigidbody2D rb;
    private Animator animator;

    private void Start(){
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
        if(moveInput != Vector2.zero){
            bool success = MovePlayer(moveInput);
            
            if(!success){
                success = MovePlayer(new Vector2(moveInput.x, 0));

                if(!success){
                    success = MovePlayer(new Vector2(0, moveInput.y));
                }
            }
            animator.SetBool("Player_is_walking", success);
        } else{
            animator.SetBool("Player_is_walking", false);
        }
    }

    public bool MovePlayer(Vector2 direction){

        // check for potential collisions
        int count = rb.Cast(
            direction,
            movementFilter,
            castCollisions,
            moveSpeed * Time.fixedDeltaTime + collisionOffset);
        if (count == 0){
            Vector2 moveVector = direction * moveSpeed * Time.fixedDeltaTime;

            // No collisions
            rb.MovePosition(rb.position + moveVector);
            return true;
        } else{
            // Print collisions
            foreach (RaycastHit2D hit in castCollisions){
                print(hit.ToString());
            }
            return false;
        }
    }
    //public bool CheckCollisionIn(Vector2 direction, float distance)
   //{
     //   collisionResults = new RaycastHit2D[2];

       // return colliderToCast.Cast(direction, collisionResults, distance) > 0;
    //}

    //internal void StopMovementX() => velocity = new Vector2(0,velocity.y);
    //public void StopMovementBothAxis() => velocity = new Vector2.zero;

    void OnMove(InputValue value) {
        moveInput = value.Get<Vector2>();

        // Only set the animation direction if the player is trying to move (idle positions)
        if(moveInput != Vector2.zero){
            animator.SetFloat("XInput", moveInput.x);
            animator.SetFloat("YInput", moveInput.y);
        }
    }
}
