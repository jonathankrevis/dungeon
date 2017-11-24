using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour {

	public float SpeedMovement;
	public float JumpPower;
	public float MaxSpeed;
	public bool CanJump = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (GetComponent<Rigidbody>().velocity.magnitude < MaxSpeed)
		{
			if (Input.GetKey(KeyCode.Z))
			{
				GetComponent<Rigidbody>().AddForce(transform.forward * SpeedMovement);
			}

			if (Input.GetKey(KeyCode.Q))
			{
				GetComponent<Rigidbody>().AddForce(-transform.right * SpeedMovement);
			}

			if (Input.GetKey(KeyCode.S))
			{
				GetComponent<Rigidbody>().AddForce(-transform.forward * SpeedMovement);
			}

			if (Input.GetKey(KeyCode.D))
			{
				GetComponent<Rigidbody>().AddForce(transform.right * SpeedMovement);
			}

			if (Input.GetKeyDown(KeyCode.Space) && CanJump)
			{
				GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpPower, 0));
			}
		}

		CanJump = false;
	}

	private void OnTriggerStay(Collider other) 
	{
		CanJump = true;
	}

//	private void OnCollisionStay(Collider collision) 
//	{
//		
//	}
}
