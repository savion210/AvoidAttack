using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Reference to the player camera
	public Camera PlayerCam; 

	//Movement Variables
	public float MoveSpeed;

	public float JumpHeight;

	//GroundCheck
	public bool IsGrounded;

    //Checking to
    public bool HasPickup;

	// Player Rotation
	public float speedH; 
	public float speedV;
	private float yaw = 0.0f;
	private float pitch = 0.0f;

    public bool ForceAbility;/// <summary>
    /// Whichever one of these is true then that ability is active...
    /// if whichever bool is true then {fucntianlity for that ability goes *here*}
    /// </summary>
    public bool LaserAbility;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		//Player Movement
		if (Input.GetKey (KeyCode.W))
		{
			transform.Translate (MoveSpeed * Time.deltaTime, 0, 0); //Move forward
		}

		if (Input.GetKey (KeyCode.S))
		{
			transform.Translate (-MoveSpeed * Time.deltaTime, 0, 0); //Move back
		}

		if (Input.GetKey (KeyCode.A))
		{
			transform.Translate (0, 0, MoveSpeed * Time.deltaTime); //Move left
		}

		if (Input.GetKey (KeyCode.D))
		{
			transform.Translate (0, 0, -MoveSpeed * Time.deltaTime); //Move right
		}

		if (Input.GetKeyDown (KeyCode.Space) && IsGrounded)
		{
			transform.Translate (0,  JumpHeight * Time.deltaTime, 0); //Move Up/Jump
		}
        //Player movemnt ends here

        //Functionality for the the different abilties

        if (ForceAbility)
        {
            Debug.Log("Force push is active");
        }

        if (LaserAbility)
        {
            Debug.Log("Laser blast is active");
        }

        //Functionality for the the different abilties ends here

        // Player rotation
        yaw += speedH * Input.GetAxis("Mouse X");
		pitch -= speedV * Input.GetAxis("Mouse Y");

		transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
        //player roatation ends here
	}

    public void PickUp ()
    {

    }

	

	void OnTriggerEnter (Collider enter)
	{
		if (enter.gameObject.tag == "Ground")
		{
			IsGrounded = true;
		}
	}

	void OnTriggerStay (Collider stay)
	{
		if (stay.gameObject.tag == "Ground")
		{
			IsGrounded = true;
		}
	}

	void OnTriggerExit (Collider exit)
	{
		if (exit.gameObject.tag == "Ground")
		{
			IsGrounded = false;
		}
	}
}
