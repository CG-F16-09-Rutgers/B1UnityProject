using UnityEngine;
using System.Collections;

public class AgentScript : MonoBehaviour {
	public int aindex;
	public Vector3 target;
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		target.Set ((float)-3.6, (float)2.0, (float)4.5);
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination (target);
	}
}
