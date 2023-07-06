using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ricardo : MonoBehaviour
{
    public NavMeshAgent AI;
    public Transform Player;
    Vector3 dest;

    private void Update()
    {
        dest = Player.position;
        AI.destination = dest;
    }
}
