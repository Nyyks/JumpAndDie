using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilePlayerMovement : MonoBehaviour {

	public CharacterController2D controller;

	public Animator animator;

	public float runSpeed = 40f;

	public Joystick joystick;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	private SceneHandler sceneHandler;


	// Update is called once per frame
	void Update () {

		if (joystick.Horizontal >= .2f)
		{
			horizontalMove = runSpeed;
		} else if (joystick.Horizontal <= -.2f)
		{
			horizontalMove = -runSpeed;
		} else
		{
			horizontalMove = 0f;
		}

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		



	}
	public void Jump()
	{
		sceneHandler.SaveScene();
		jump = true;
		animator.SetBool("IsJumping", true);
	}


	public void OnLanding()
	{
		animator.SetBool("IsJumping", false);
	}

	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}



	void Awake()
	{
		sceneHandler = GameObject.FindGameObjectWithTag("SceneHandler").GetComponent<SceneHandler>();
	}



}
