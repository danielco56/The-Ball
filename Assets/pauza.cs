using UnityEngine;
using System.Collections;

public class pauza : MonoBehaviour {

	private bool pauz=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyUp (KeyCode.P) && !pauz) {


			pauzjoc ();

		} else if (Input.GetKeyUp (KeyCode.P) && pauz) {
			resume ();
		}
	}

	 void pauzjoc()
	{
		pauz = true;
		Time.timeScale = 0;
	}
	 void resume()
		{
			pauz = false;
			Time.timeScale = 1;
		}
}
 
