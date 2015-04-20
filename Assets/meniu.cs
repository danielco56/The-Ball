using UnityEngine;
using System.Collections;

public class meniu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void start()
	{
		Application.LoadLevel("1");
	}
	public void iesire()
	{
		Application.Quit ();
	}
    public void nivele()
    {
		Application.LoadLevel ("meniu_nivele");
    }

}