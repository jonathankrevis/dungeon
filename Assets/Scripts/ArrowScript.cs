using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 4);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision c)
	{
		Destroy(gameObject);
	}
}
