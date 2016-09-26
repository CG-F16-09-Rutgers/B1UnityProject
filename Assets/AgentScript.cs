using UnityEngine;
using System.Collections;

public class AgentScript : MonoBehaviour {
	public int aindex;
	public Vector3 target;
	NavMeshAgent agent;
	public int minDistance;
	public int avPri;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		//target.Set ((float)-3.6, (float)2.0, (float)4.5);
		target.Set (transform.position.x, transform.position.y, transform.position.z);
		agent.avoidancePriority = avPri;
	}
	
	// Update is called once per frame
	void Update () {
		//while(Vector3.Distance(transform.position, target) > minDistance)
			agent.SetDestination (target);
		//Basically, once the agent is > min distance away, do agent.stop() or something
	}
}
