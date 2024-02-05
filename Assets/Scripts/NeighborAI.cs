using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeighborAI : MonoBehaviour
{
	protected UnityEngine.AI.NavMeshAgent agent;
	
	[SerializeField] protected Transform[] waypoints;
	public float agnetSpeed = 0.5f;
	int waypointIndex;
	Vector3 target;

	void Update()
	{

		if (waypoints != null && Vector3.Distance(transform.position, target) < 1)
		{
			iterateIndex();
			traverseWaypoints();
		}
		
	}

	void Start()
	{
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>(); // Added missing angle brackets	
		agent.speed = agnetSpeed;

		traverseWaypoints();
	}



	void traverseWaypoints()
	{
		if (waypoints != null && waypoints.Length > 0)
		{
			int randomWaypoint = Random.Range(0, waypoints.Length);
			target = waypoints[randomWaypoint].position;
			agent.SetDestination(target);
		}
	}

	void iterateIndex()
	{
		waypointIndex = (waypointIndex + 1) % waypoints.Length;
	}
}