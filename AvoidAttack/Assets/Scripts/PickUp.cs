using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public bool LaserBlast;/// <summary>
    /// Which ability will be active
    /// </summary>
    public bool ForcePush;


    public int Ability; /// <summary>
    /// Which ability is being selected to be active ///Each ability is set to a specific number/int/////
    /// </summary>

    // Use this for initialization

    public PlayerController ThePlayer; /// <summary>
    /// Gaining access to the player controller to activate the bools which control which the fucntianlity for the player abilitys
    /// </summary>
        
    void Start () {
        Ability = Random.Range(0, 3); //Randomly Select an ability
        ThePlayer = GameObject.Find("ThePlayer").GetComponent<PlayerController>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Ability == 1) // 1 = Laser blast
        {
           
            LaserBlast = true;
            ThePlayer.LaserAbility = true;
        }

        if (Ability == 2) // 2 = force push 
        {
            ThePlayer.ForceAbility = true;
            ForcePush = true;

        }
		
	}

     void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Player")
        {

            Destroy(other.gameObject);
        }
    }
}
