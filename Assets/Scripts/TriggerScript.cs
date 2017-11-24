using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

	public float Speed;
	public bool IsOpen = false;
	public Vector3 StartPosition;
	public Vector3 EndPosition;

//	public Color StColor, EndColor, CurrentColor;

//	[Range(0,1)]
	private float timer = 0;

	private void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Player")
		{
			IsOpen = true;
			timer = 0;
		}
	}

	private void OnTriggerStay(Collider c)
	{
		Debug.Log("STAY");
	}

	private void OnTriggerExit(Collider c)
	{
		if (c.tag == "Player")
		{
			IsOpen = false;
			timer = 1;
		}
	}

	void Update()
	{
		transform.localPosition = Vector3.Lerp(
			StartPosition,
			EndPosition,
			(Mathf.Sin(Time.time) + 1) / 2
		);

//		if(IsOpen) {
//			timer += Time.deltaTime;
//		} else {
//			timer -= Time.deltaTime;
//		}
//
//		transform.localPosition = Vector3.Lerp(StartPosition, EndPosition, timer);

//		Debug.Log(Mathf.Lerp(0, 10, timer));
//		CurrentColor = Color.Lerp(StColor, EndColor, timer);
//		if (IsOpen) {
//			Mathf.Lerp(0, 1, f);
//		} else {
//
//		}
	}
}
