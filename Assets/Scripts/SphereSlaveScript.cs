using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereSlaveScript : MonoBehaviour {

	public Transform MasterTransform;

	public float timer;

	void Start () 
	{
		timer = 0;
	}

	void Update()
	{
		timer += Time.deltaTime;
		transform.localPosition = Vector3.Lerp(
			transform.localPosition,
			MasterTransform.localPosition,
			0.1f);
	}
}
