using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroFloorControl : MonoBehaviour {
	Vector3 angle;
	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		GyroModifyFloor ();
	}

	void GyroModifyFloor()
	{
		transform.rotation = GyroToUnity (Input.gyro.attitude);
	}

	private static Quaternion GyroToUnity(Quaternion q)
	{
		return new Quaternion (q.x, 1, q.y, q.w);
	}
}
