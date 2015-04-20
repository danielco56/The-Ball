using UnityEngine;
using System.Collections;

public class meniu_nivele : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void nivel1 ()
	{
		Application.LoadLevel("1");
	}
	public void nivel2 ()
	{
		Application.LoadLevel("2");
	}
	public void nivel3()
	{
		Application.LoadLevel("3");
	}
	public void inapoi()
	{
		Application.LoadLevel("meniul");
	}


}
