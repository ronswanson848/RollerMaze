using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour {

	public Transform dp; 
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = dp.position;
	}
}
