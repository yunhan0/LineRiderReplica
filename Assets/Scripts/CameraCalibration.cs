using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCalibration : MonoBehaviour {

	public Transform player;
	private float offset = -2.0f;
	private bool startCalibration = false;

	void Update() {
		if (startCalibration)
			return;
		if (player.position.y <= transform.position.y)
			startCalibration = true;
	}

	void LateUpdate() {
		if (startCalibration) {
			transform.position = new Vector3 (0.0f, player.transform.position.y + offset, -10.0f);
		}
	}
}
