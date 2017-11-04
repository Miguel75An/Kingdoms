using UnityEngine;
using System.Collections;

public class Swipe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody>();

		rb.mass = 10f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
