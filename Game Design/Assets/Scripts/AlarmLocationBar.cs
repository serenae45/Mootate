using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AlarmLocationBar : MonoBehaviour
{
    public GameObject Player;
    public GameObject alarm;
    private float currentDistance;
    public int maxDistance;
    public Image mask;
    public float timeValue;
    Vector2 alarmPosition;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeValue -= Time.deltaTime;

        if (timeValue >= 110)
        {
            float fillAmount = 0f;
            mask.fillAmount = fillAmount;
            //Debug.Log("fill amount: " + fillAmount);
        }

        else
        {
            GetDistance();
            GetCurrentFill();
        } 
    }

    void GetCurrentFill()
    {
        float howClose = (float)currentDistance / (float)maxDistance;
        float fillAmount = 1 - howClose;
        mask.fillAmount = fillAmount;
        //Debug.Log("how close: " + howClose);
        //Debug.Log("fill amount: " + fillAmount);
    }

    void GetDistance()
    {
        RandomPositionSpawn alarmPositionScript = alarm.GetComponent<RandomPositionSpawn>();
        alarmPosition = alarmPositionScript.GetAlarmPosition();
        
        float distance = Vector2.Distance(Player.transform.position, alarmPosition);

        currentDistance = Mathf.Abs(distance);
        //Debug.Log("distance: " + currentDistance);
    }
}
