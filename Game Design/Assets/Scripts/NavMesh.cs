using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    Transform movePosition;
    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        Walking walkingScript = gameObject.GetComponent<Walking>();
        movePosition = walkingScript.GetTransform();
        navMeshAgent.destination = movePosition.position;
    }
}
