using UnityEngine;
using System.Collections;

public class LM : MonoBehaviour {
	public int scor;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AdaugarePuncte(int puncte)
	{
		scor = scor + puncte;
	}

	void OnGUI ()
	{
		GUI.Box (new Rect(30,30, 100, 25), "SCOR: "+scor);
	}
}
