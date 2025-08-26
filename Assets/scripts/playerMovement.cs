using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

	
	// public vars
	public int speed = 100;
	public GameObject SUN;

	// System vars
	Vector3 moveAmount;
	Vector3 smoothMoveVelocity;

	void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void Update()
	{

		// Look rotation:
		transform.LookAt(SUN.GetComponent<Renderer>().bounds.center);

		// Calculate movement:
		float inputX = Input.GetAxisRaw("Horizontal");
		float inputY = Input.GetAxisRaw("Vertical");
		float inputZ = Input.GetAxisRaw("Mouse ScrollWheel");

		// player movement
		Vector3 moveDir = new Vector3(inputX, inputY , inputZ) * speed;
		moveAmount = Vector3.SmoothDamp(moveAmount, moveDir, ref smoothMoveVelocity, .2f);

		Vector3 localMove = transform.TransformDirection(moveAmount) * Time.deltaTime;

		transform.position += localMove;

	}

}
