using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	

    public bool B1; /// <summary>
    /// /These bools are used to check to if the buttons have been pressed/////////
    /// </summary>
    public bool B2;
    public bool B3;
    public bool B4;

    public bool IsPickup;

    public ButtonManager[] Buttons;



    //public ButtonManager MyButtonManger; // Calling on ButtonManger to gain access to its public variables and fucntions
   
    void Start () {

    
    }
	
	// Update is called once per frame
	void Update () {

        if (B1 && B2 && B3 && B4 && IsPickup) 
        {
            Debug.Log("All Buttons Have been Activated!!!");
            foreach(ButtonManager Button in Buttons)
            {
                Button.Reset(); 
            }
        }

    }

}

