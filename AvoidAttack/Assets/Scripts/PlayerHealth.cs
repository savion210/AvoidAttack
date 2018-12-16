using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public Slider PlayerHealthSlider;

	public float PlayerDamaged = 5;

	public Rigidbody force;

	public float knockback;


	// Use this for initialization
	void Start () {
		force = GetComponent <Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		CheckDeath ();
	}



	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag == "Sword")
		{
			PlayerHealthSlider.value -= PlayerDamaged;
			force.AddForce (-transform.forward * knockback);
		}
	}



	void CheckDeath ()
	{
		if (PlayerHealthSlider.value <= 0)
		{
			Destroy (gameObject);
		}
	}
}
