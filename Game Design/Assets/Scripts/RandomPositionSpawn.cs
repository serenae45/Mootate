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

    // public float minX, maxX, minY, maxY; // Define spawn area boundaries
    // public LayerMask obstacleLayer;      // LayerMask for detecting obstacles
    // public float spawnRadius = 0.5f;     // Radius for checking collisions

    // void SetPos()
    // {
    //     int maxAttempts = 20; // Prevents infinite loops
    //     int attempts = 0;
    //     bool validPosition = false;

    //     while (!validPosition && attempts < maxAttempts)
    //     {
    //         // Generate a random position within bounds
    //         float randomX = Random.Range(minX, maxX);
    //         float randomY = Random.Range(minY, maxY);
    //         Vector2 randomPosition = new Vector2(randomX, randomY);

    //         // Check if the position is valid (not colliding)
    //         if (!Physics2D.OverlapCircle(randomPosition, spawnRadius, obstacleLayer))
    //         {
    //             alarmPosition = randomPosition;
    //             validPosition = true;
    //         }
    //         attempts++;
    //     }

    //     // Instantiate the alarm if a valid position is found
    //     if (validPosition)
    //     {
    //         Instantiate(alarmTrigger, alarmPosition, Quaternion.identity);
    //         Debug.Log("Alarm spawned at: " + alarmPosition);
    //     }
    //     else
    //     {
    //         Debug.LogWarning("Failed to find a valid spawn position after " + maxAttempts + " attempts.");
    //     }
    // }

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
