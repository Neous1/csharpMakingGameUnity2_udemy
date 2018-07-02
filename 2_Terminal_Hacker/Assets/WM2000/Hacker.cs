using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Hello Console");
		Terminal.WriteLine("What would you like to hack into?");
		Terminal.WriteLine("Press 1 for the local library");
		Terminal.WriteLine("Press 2 for the Police Station");
		Terminal.WriteLine("Enter you Selection: ");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
