using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float range;
    [SerializeField]
    float maxDistance;
    //public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public GameObject character;
    Vector2 movement;
    Transform movePosition;


    // Start is called before the first frame update
    void Start()
    {
        if(character.name != "Player")
        {
            SetNewDestination();
        }
    }

    // Update is called once per frame
    void Update()
    {   
        transform.position = Vector2.MoveTowards(transform.position, movement, speed*Time.deltaTime);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if(Vector2.Distance(transform.position, movement) < range)
        {
            SetNewDestination();
        }
    }

    void SetNewDestination()
    {
        //movement = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance,maxDistance));
        movement = new Vector2(Random.Range(-maxDistance - 4, maxDistance + 4), Random.Range(-maxDistance,maxDistance));

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        //CheckDestination();
    }

    void CheckDestination()
    {
        if(!Physics2D.OverlapCircle(movement, 0.1f))
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);

            movePosition.position = Vector2.MoveTowards(transform.position, movement, speed*Time.deltaTime);
        }
        else
        {
            SetNewDestination();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Untagged")
        {
            SetNewDestination();
        }

        if(collision.gameObject != character)
        {
            SetNewDestination();
        }

    }

    public Transform GetTransform()
    {
        return movePosition;
    }
}
