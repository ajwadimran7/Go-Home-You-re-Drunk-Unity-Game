using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float ZAxisSpeed;
	public float XAxisSpeed;

	//public float maxSpeed;

	public float minRandomXSpeed;
	public float maxRandomXSpeed;

	Rigidbody rb;
	public float sign = 1f;

	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
		
	void Update () {
		
		float xSpeed = Random.Range (minRandomXSpeed,maxRandomXSpeed);
		//if (rb.velocity.z < maxSpeed) {
		Vector3 speed = new Vector3 ((xSpeed + XAxisSpeed) * sign, 0f, ZAxisSpeed);
		//} else {
		//	speed = new Vector3 (xSpeed, 0f, 0f);
		//}
		transform.Translate(speed * Time.deltaTime);
		Debug.Log (speed * Time.deltaTime);
		//rb.AddForce (speed * speedMultiplier *Time.deltaTime);
		
		//Debug.Log (rb.velocity.x);
	}

	public void setXSpeedSign(float _sign) {
		sign = _sign;
	}
}
