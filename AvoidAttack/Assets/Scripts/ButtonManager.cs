using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public bool Button1;

    public bool Button2;

    public bool Button3;

    public bool Button4;

    public bool InTrigger = false;

    public GameManager MyGameManager;


    // Start is called before the first frame update
    void Start()
    {
        MyGameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

       

        GetComponent<MeshRenderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        if (Button1 && InTrigger && Input.GetKeyDown(KeyCode.Tab))
        {
            GetComponent<MeshRenderer>().material.color = Color.green;

            MyGameManager.B1 = true;
        }

        if (Button2 && InTrigger && Input.GetKeyDown(KeyCode.Tab))
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            MyGameManager.B2 = true;
        }

        if (Button3 && InTrigger && Input.GetKeyDown(KeyCode.Tab))
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            MyGameManager.B3 = true;
        }

        if (Button4 && InTrigger && Input.GetKeyDown(KeyCode.Tab))
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            MyGameManager.B4 = true;
        }
    }

    public void Reset()
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
        MyGameManager.B1 = false;
        MyGameManager.B2 = false;
        MyGameManager.B3 = false;
        MyGameManager.B4 = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player is in Trigger!!");

            InTrigger = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player is still here!!");
            InTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player has left Trigger!!");
            InTrigger = false;
        }
    }
}
