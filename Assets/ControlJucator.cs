using UnityEngine;
using System.Collections;

public class ControlJucator : MonoBehaviour {
	public float viteza;
	private Vector3 input;
	void Start () {
	
	}
	

	void Update () {

		input=new Vector3(Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical"));
			GetComponent<Rigidbody>().AddForce (input * viteza);

	}
	
}