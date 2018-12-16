using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour {

	public float lookRadius = 10.0f;

	Transform target; // the target the enemy needs to track which be used as a reference from singleton code

	NavMeshAgent agent; //Getting reference to the navmesh component attached to the Enemy


	// Use this for initialization
	void Start () { 

		target = PlayerTracker.instance.Player.transform; //Reference to singleton code that tracks the player  
		agent = GetComponent <NavMeshAgent> ();

	}


	
	// Update is called once per frame
	void Update () {

		float distance = Vector3.Distance (target.position, transform.position); // distance between the player and the enemy

		if (distance <= lookRadius) 
		{
			agent.SetDestination (target.position);

			if (distance <= agent.stoppingDistance)
			{
				
				 //Attack the target

				//Face target
				FaceTarget ();
			}
		}
	}

	void FaceTarget () // Face the target if in look radius
	{
		Vector3 direction = (target.position - transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation (new Vector3 (direction.x, 0, direction.z));
		transform.rotation = Quaternion.Slerp (transform.rotation, lookRotation, Time.deltaTime * 5f);
	}

	void OnDrawGizmosSelected () //Shows the sight radius on the ai
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere (transform.position, lookRadius);
	}


}
