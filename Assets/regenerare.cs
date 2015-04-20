using UnityEngine;
using System.Collections;

public class regenerare : MonoBehaviour {
	public Transform cad;
	public Transform regen;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {

		if (other.transform == cad)
			transform.position = regen.position;
	}

}
