using UnityEngine;
using System.Collections;

public class rotatie : MonoBehaviour
{
	public float viteza;
	
	
	void Update ()
	{
		transform.Rotate(Vector3.up, viteza * Time.deltaTime);
	}
}