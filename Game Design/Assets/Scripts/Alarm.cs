using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{

    public Transform Spawnpoint;
    public Rigidbody2D Prefab;
    public GameObject Player;

    void OnTriggerEnter2D(Collider2D player)
    {
        Rigidbody2D RigidPrefab;
        if (player.gameObject == Player){
            RigidPrefab = Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation) as Rigidbody2D;
        }
    }

}
