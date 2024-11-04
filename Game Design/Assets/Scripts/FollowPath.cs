using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    public Animator animator;
    public GameObject character;
    [SerializeField]
    private Transform[] waypoints;

    [SerializeField]
    private float moveSpeed =2f;
    Vector2 newPostion;
    Vector2 oldPosition;

    private int waypointIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        oldPosition = character.transform.position;
        Move();
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (waypointIndex <= waypoints.Length - 1)
        {
            
            newPostion = Vector2.MoveTowards(character.transform.position, 
                                                     waypoints[waypointIndex].transform.position,
                                                     moveSpeed * Time.deltaTime);

            character.transform.position = newPostion;

            //float x_val = Mathf.Abs(character.transform.position.x) - Mathf.Abs(movement.x);
            //float y_val = Mathf.Abs(character.transform.position.y) - Mathf.Abs(movement.y);

            //float x_val = Mathf.Abs(oldPosition.x) - Mathf.Abs(waypoints[waypointIndex].transform.position.x);
            //float y_val = Mathf.Abs(oldPosition.y) - Mathf.Abs(waypoints[waypointIndex].transform.position.y);

            //float x_val = oldPosition.x - Mathf.Abs(waypoints[waypointIndex].transform.position.x);
            //float y_val = oldPosition.y - Mathf.Abs(waypoints[waypointIndex].transform.position.y);

            //float x_val = Mathf.Abs(oldPosition.x) - waypoints[waypointIndex].transform.position.x;
            //float y_val = Mathf.Abs(oldPosition.y) - waypoints[waypointIndex].transform.position.y;

            //float x_val = oldPosition.x + waypoints[waypointIndex].transform.position.x;
            //float y_val = oldPosition.y + waypoints[waypointIndex].transform.position.y;

            //float x_val = oldPosition.x + newPostion.x;
            //float y_val = oldPosition.y + newPostion.y;

            //float x_val = Mathf.Abs(waypoints[waypointIndex].transform.position.x) - Mathf.Abs(oldPosition.x);
            //float y_val = Mathf.Abs(waypoints[waypointIndex].transform.position.y) - Mathf.Abs(oldPosition.y);

            //float x_val = Mathf.Abs(waypoints[waypointIndex].transform.position.x) - Mathf.Abs(newPostion.x);
            //float y_val = Mathf.Abs(waypoints[waypointIndex].transform.position.y) - Mathf.Abs(newPostion.y);

            float x_val = waypoints[waypointIndex].transform.position.x - newPostion.x;
            float y_val = waypoints[waypointIndex].transform.position.y - newPostion.y;

            animator.SetFloat("Horizontal", x_val);
            animator.SetFloat("Vertical", y_val);
            animator.SetFloat("Speed", newPostion.sqrMagnitude);                                         

            if (character.transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
                oldPosition = character.transform.position;
            }                                         
        }
    }
}
