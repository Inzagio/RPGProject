﻿using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotor : MonoBehaviour
{
    private NavMeshAgent agent;

	// Use this for initialization
	void Start ()
	{
	    agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MoveToPoint(Vector3 point)
    {
        agent.SetDestination(point);
    }
}
