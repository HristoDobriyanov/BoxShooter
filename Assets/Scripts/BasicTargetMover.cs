using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BasicTargetMover : MonoBehaviour
{
    public float spinSpeed = 180.0f;
	public float motionMagnitude = 0.1f;
	public bool spin = true;
	public bool move = false;

    // Update is called once per frame
    void Update()
    {
		// Rotate around the up axis of the game object
		if (spin) {
			gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
		}

		// Move up and down over time
		if (move) {
			gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);

		}
    }
}
