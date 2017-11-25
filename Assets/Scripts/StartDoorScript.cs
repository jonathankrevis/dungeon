using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDoorScript : MonoBehaviour {

	public Transform from;
	public Transform to;
	public float speed = 0.1F;
	public bool IsOpen = false;

	void Update() {
		
	}

	// Use this for initialization
	void Start () {
		
	}	

	private void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player")
		{
			transform.rotation = Quaternion.Lerp(from.rotation, to.rotation, Time.time * speed);
		}
	}

	private void OnTriggerExit(Collider c)
	{
		if (c.tag == "Player")
		{
			transform.rotation = Quaternion.Lerp(to.rotation, from.rotation, Time.time * speed);
		}
	}
}
