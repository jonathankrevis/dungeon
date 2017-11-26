using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldTargetScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.tag == "Arrow")
		{
			Destroy(gameObject);

			GameObject Bridge = GameObject.Find("Bridge");
//			float y = Bridge.transform.position.y;
//			Bridge.transform.position = new Vector3(0, y + 6, 0);

			Bridge.transform.Translate(Vector3.up * 6, Space.World);
		}
	}
}
