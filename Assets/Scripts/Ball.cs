using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float speed = 100.0f;

	// Use this for initialization
	void Start () {
		
	}


	void OnCollisionEnter2D(Collision2D collision){ 
		if(collision.gameObject.name == "racket"){
			float x = ballHitAngle(
				transform.position,
				collision.transform.position, collision.collider.bounds.size.x);
			Vector2 direction = new Vector2(x, 1).normalized;
			GetComponent<Rigidbody2D>().velocity = direction * speed;
			//GetComponent<Rigidbody2D> ().velocity = Vector2.up * speed ;
		} 
	}

	float ballHitAngle(Vector2 ballPosition, Vector2 racketPosition,float racketWidth ){
		return (ballPosition.x - racketPosition.x) / racketWidth;

	}

	// Update is called once per frame
	void Update () {

	}
}
