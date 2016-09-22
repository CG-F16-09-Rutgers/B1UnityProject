using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
	public int NumberOfAgents;
	public AgentScript prefab;
	public int i;
	// Use this for initialization
	void Start () {
		while (NumberOfAgents > 0) {
			AgentScript AnAgent = (AgentScript)Instantiate (prefab, new Vector3(2*Random.value - 1, 3, 2*Random.value-1), Quaternion.identity);
			i = i + 1;
			AnAgent.aindex = i;
			NumberOfAgents = NumberOfAgents - 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
