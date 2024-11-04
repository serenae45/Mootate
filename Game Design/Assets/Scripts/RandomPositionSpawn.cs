using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPositionSpawn : MonoBehaviour
{
    public GameObject alarmTrigger;
    public Transform[] locations;
 
    public float timeValue;
    private int numRuns = 0;
    private Transform alarmPosition;

    void setPos(){
        // make random integer
        int randomPos = Random.Range(0,locations.Length);
        // select the random location
        alarmPosition = locations[randomPos];
        // instantiate the alarm
        Instantiate(alarmTrigger, alarmPosition.position, Quaternion.identity);
        Debug.Log("alarm position: " + randomPos);

    }

    void Update()
    {
        if (timeValue > 0){
            timeValue -= Time.deltaTime;
        }
        else {
            timeValue = 0;
        }

        if ((int)timeValue == 110 && numRuns == 0) {
            // instantiate the alarm
            setPos();
            numRuns =+1;
        }
    }

    public Vector2 GetAlarmPosition()
    {
        return alarmPosition.position;
    }

}
