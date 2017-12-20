using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, Random.Range (-0.1f, 0.2f));
		transform.Rotate (0, Random.Range (-2, 2), 0);
	}
}
