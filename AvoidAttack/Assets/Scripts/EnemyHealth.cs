using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHealth : MonoBehaviour {


	public Slider EnemyHealthSlider;

	public float EnemyDamaged = 5;

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
		if (other.gameObject.tag == "Player")
		{
			EnemyHealthSlider.value -= EnemyDamaged;
			force.AddForce (-transform.forward * knockback);
		}
	}



	void CheckDeath ()
	{
		if (EnemyHealthSlider.value <= 0)
		{
			Destroy (gameObject);
		}
	}
}
