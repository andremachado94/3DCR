using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CnControls;


/*
public class PlayerController : MonoBehaviour {

	public float speed = 1;
	Rigidbody rigidbody;
	public float turnSmoothTime = 0.2f;
	float turnSmoothVelocity;


	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>();

	}


	void FixedUpdate ()
	{

		Vector3 movement = new Vector3(CnInputManager.GetAxis("Horizontal"), 0f, CnInputManager.GetAxis("Vertical"))*speed;
		Vector3 movementDir = movement.normalized;

		if (movementDir != Vector3.zero) {
			float targetRotation = Mathf.Atan2 (movementDir.x, movementDir.z) * Mathf.Rad2Deg;
			transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle (transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, turnSmoothTime);
		}

		rigidbody.velocity = movement * speed;

	}
}*/




[RequireComponent (typeof (Rigidbody))]
public class PlayerController : MonoBehaviour {

	Rigidbody myRigidbody;
	public float turnSmoothTime = 0.2f;
	float turnSmoothVelocity;
	public float speed = 3f;

	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
	}

	public void Move() {
		Vector3 movement = new Vector3(CnInputManager.GetAxis("Horizontal"), 0f, CnInputManager.GetAxis("Vertical"))*speed;
		Vector3 movementDir = movement.normalized;

		if (movementDir != Vector3.zero) {
			float targetRotation = Mathf.Atan2 (movementDir.z, -movementDir.x) * Mathf.Rad2Deg;
			transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle (transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, turnSmoothTime);
		}

		myRigidbody.velocity = movement * speed;
	}

	/*public void LookAt(Vector3 lookPoint) {
		Vector3 heightCorrectedPoint = new Vector3 (lookPoint.x, transform.position.y, lookPoint.z);
		transform.LookAt (heightCorrectedPoint);
	}

	void FixedUpdate() {
		myRigidbody.MovePosition (myRigidbody.position + velocity * Time.fixedDeltaTime);

	}*/
}


