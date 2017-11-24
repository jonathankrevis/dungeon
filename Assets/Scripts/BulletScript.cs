using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 4);
	}
	
	// Update is called once per frame
	void Update () {

	}

	private void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.GetComponent<LifeScript>())
		{
			c.gameObject.GetComponent<LifeScript>().Damage(5);
		}

		Destroy(gameObject);
	}
}
