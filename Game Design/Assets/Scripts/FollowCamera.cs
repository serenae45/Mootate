using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public Transform target;
    private Vector3 offset;

    void Start()
    {
        //offset = transform.position - target.position;
    }
    void Update()
    {        
        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f); //+ offset;
        transform.position = Vector3.Slerp(transform.position, newPos, FollowSpeed*Time.deltaTime); 
    }
}
    //void Update()
    //{        
        //AspectRatioBoxChange();
//        CalculatePivot();
//        FollowPlayer();
  //  }

    //void AspectRatioBoxChange()
    //{
      //  float height = 2f * cam.orthographicSize;
        //float width = height * cam.aspect;
        //cameraBox.size = new Vector2(width, height);
    //}

    //void CalculatePivot()
    //{
       // bottomPivot = boundary.bounds.min.y + cameraBox.size.y/2;
       // topPivot = boundary.bounds.max.y - cameraBox.size.y/2;
       // leftPivot = boundary.bounds.min.x + cameraBox.size.x/2;
       // rightPivot = boundary.bounds.max.x - cameraBox.size.x/2;
    //}

    //void FollowPlayer()
   // {
       // transform.position = new Vector3(Mathf.Clamp(target.position.x, leftPivot, rightPivot),
                                         //Mathf.Clamp(target.position.y, bottomPivot, topPivot),
                                         //-10f);
    //}

