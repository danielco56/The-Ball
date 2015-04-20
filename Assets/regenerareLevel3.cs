using UnityEngine;
using System.Collections;

public class regenerareLevel3 : MonoBehaviour {
	
	public Transform cad3;
	public Transform regen3;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other) {
		
		if (other.transform == cad3) {
			
			Application.LoadLevel("3");
		}
	}
	
}