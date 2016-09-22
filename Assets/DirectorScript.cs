using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DirectorScript : MonoBehaviour {
	public Camera thecamera;
	private RaycastHit hit;
	private List<AgentScript> agents;
	public Vector3 target;
	int i;
	private bool found;


	// Use this for initialization
	void Start () {
		agents = new List<AgentScript>();
		found = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = thecamera.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				print (hit.collider.name + " " + hit.collider.tag);
				if (hit.collider.CompareTag ("agent")) {
					foreach (AgentScript ag in agents) {
						if (ag.aindex == hit.collider.GetComponent<AgentScript> ().aindex) {
							agents.RemoveAt (i);
							found = true;
							break;
						}
						i = i + 1;
					}

					if (found == false) {
						agents.Add (hit.collider.GetComponent<AgentScript>());
					}
					found = false;
					i = 0;
				}
			}
		}
		if (Input.GetMouseButtonDown (1)) {
			Ray ray = thecamera.ScreenPointToRay (Input.mousePosition);
			if(Physics.Raycast(ray, out hit)){
				//if(!hit.collider.CompareTag("wall")){
					foreach (AgentScript ag in agents) {
						ag.target = hit.point;
					}
				//}
			}
		}
		if (Input.GetKeyDown (KeyCode.D)) {
			agents.Clear ();
		}
	}
}
