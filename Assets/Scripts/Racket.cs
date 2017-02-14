﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour {

	public float speed = 150.0f;

	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxisRaw ("Horizontal");
		GetComponent<Rigidbody2D>().velocity = Vector2.right * horizontal * speed;

	}
}
