using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour {
	public GameObject FrontObs;
	public GameObject FR;
	public GameObject FL;
	public GameObject sideL;
	public GameObject sideR;
	public GameObject under;

	bool flagF = false;
	bool flagFR = false;
	bool flagFL = false;
	bool flagSR = false;
	bool flagSL = false;
	bool flagB = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.F1)) {
			FrontObs.SetActive (flagF);
			flagF = !flagF;
		}
		if (Input.GetKeyDown(KeyCode.F2)) {
			FR.SetActive (flagFR);
			flagFR = !flagFR;
		}
		if (Input.GetKeyDown(KeyCode.F3)) {
			FL.SetActive (flagFL);
			flagFL = !flagFL;
		}
		if (Input.GetKeyDown(KeyCode.F4)) {
			sideR.SetActive (flagSR);
			flagSR = !flagSR;
		}
		if (Input.GetKeyDown(KeyCode.F5)) {
			sideL.SetActive (flagSL);
			flagSL = !flagSL;
		}
		if (Input.GetKeyDown(KeyCode.B)) {
			under.SetActive (flagB);
			flagB = !flagB;
		}
	}
}
