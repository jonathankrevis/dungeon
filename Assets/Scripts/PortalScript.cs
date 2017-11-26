using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour {

	public Transform MoveToNextPortalPosition;
	public GameObject OldPlaceToDisable;

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
			c.transform.position = MoveToNextPortalPosition.position;
			OldPlaceToDisable.SetActive(false);
		}
	}
}
