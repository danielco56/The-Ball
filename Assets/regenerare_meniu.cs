using UnityEngine;
using System.Collections;

public class regenerare_meniu : MonoBehaviour {

	public Transform cad4;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		
		if (other.transform == cad4) {
			
			Application.LoadLevel("meniul");
		}
	}
	
}