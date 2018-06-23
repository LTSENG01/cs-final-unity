using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBob : MonoBehaviour
{
	private double _currStep;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = new Vector3(transform.position.x, GetYPosition(), transform.position.z);
		_currStep += 0.025;		// controls the speed of the cube

	}

	private float GetYPosition()
	{
		return (float) (Math.Sin(_currStep) + 1.5);		// assuming degrees, 1.5 is the lowest it can go
	}

}
