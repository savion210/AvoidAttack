using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {


    public Transform BasicEnemy;

    public GameObject BossEnemy;

    public float SpawnTimer;

    public bool IsBoss;

    public bool IsBasic;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (IsBoss == true)
        {

            SpawnTimer += Time.deltaTime;


            if (SpawnTimer >= 10)
            {

                ResetTimer();

                for (int y = 0; y < 1; y++)
                {
                    for (int x = 0; x < 1; x++)
                    {
                        Instantiate(BossEnemy, new Vector3(x, y, 0), Quaternion.identity);
                    }
                }

            }
        }

        if (IsBasic == true)
        {

            SpawnTimer += Time.deltaTime;


            if (SpawnTimer >=10)
            {

                ResetTimer();

                for (int y = 0; y < 1; y++)
                {
                    for (int x = 0; x < 1; x++)
                    {
                        Instantiate(BasicEnemy, new Vector3(x, y, 0), Quaternion.identity);
                    }
                }

            }
            
        }
	}

    public void ResetTimer ()
    {
        SpawnTimer = 0;  
    }

}
