using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotationScript : MonoBehaviour {

	public Transform CamTransform;
	public float SpeedRotation;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float y = Input.GetAxis("Mouse X");
		float x = Input.GetAxis("Mouse Y");

		transform.eulerAngles += new Vector3(0, y, 0) * SpeedRotation;

//		float XClamp = Mathf.Clamp(CamTransform.eulerAngles.x, -60, 70);
//
//		CamTransform.eulerAngles += new Vector3(-XClamp, 0, 0) * SpeedRotation;

		CamTransform.eulerAngles += new Vector3(-x, 0, 0) * SpeedRotation;
	}
}
