using UnityEngine;
using System.Collections;

public class regenerareLevel2 : MonoBehaviour {

	public Transform cad2;
	public Transform regen2;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		
		if (other.transform == cad2) {

			Application.LoadLevel("2");
		}
	}
	
}