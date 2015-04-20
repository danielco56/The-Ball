using UnityEngine;
using System.Collections;

public class colectare : MonoBehaviour {
	public LM levmen;
	int puncte=10;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other){
		if (other.tag == "Player"){
		
			levmen.AdaugarePuncte(puncte);
			Destroy (this.gameObject);
		}}

}
