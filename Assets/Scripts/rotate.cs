﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (15, 35, 45) * Time.deltaTime,Space.World);
		//rb.velocity = new Vector3(1.0f,0.0f,0.0f)*-1;
	}
}
