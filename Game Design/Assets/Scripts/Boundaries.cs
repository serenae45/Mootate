using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 17)
        {
            transform.position = new Vector3(transform.position.x,17,0);
        }
        else if(transform.position.y <= -40)
        {
            transform.position = new Vector3(transform.position.x,-40,0);
        }
        if(transform.position.x <= -48)
        {
            transform.position = new Vector3(-48, transform.position.y,0);
        }
        else if(transform.position.x >= 30)
        {
            transform.position = new Vector3(30, transform.position.y,0);
        }
    }
}
