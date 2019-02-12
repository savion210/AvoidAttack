using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedAjob : MonoBehaviour { 

   private bool GotJob;

    private float JobResponse;  

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Just applied for a new gaming job");
    }

    // Update is called once per frame
    void Update()  
    {
        JobResponse += Time.deltaTime; 

        if (JobResponse >= 5)
        {
            Debug.Log("Took them five months to respond to my application");
            GotJob = false;
        }

      if (GotJob != true)
        {
            TimeToRage();
        }

    }


    void TimeToRage ()
    {
        Debug.Log("");
    }
}
