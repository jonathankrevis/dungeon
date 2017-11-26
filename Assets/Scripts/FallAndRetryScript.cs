using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallAndRetryScript : MonoBehaviour {

	public Transform MoveToRetryPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player")
		{
			c.transform.position = MoveToRetryPosition.position;
		}
	}
}
