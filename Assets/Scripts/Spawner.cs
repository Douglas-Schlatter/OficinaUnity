using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    // Use this for initialization

 

    public List<GameObject> grades;// spwaned enemies, at the moment in the scene
    public int rGrad;
    public int rSpwan;
    public List<GameObject> spawnPos;
    public GameObject coin;
    public int target;

    //Time Related
    public float timer = 0.0f;
    public float lSpawn = 0.0f;

	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (timer - lSpawn > 0.5)
        {
            lSpawn = timer;
            target = Random.Range(0, 4);
            rSpwan = Random.Range(0, spawnPos.Count);

            if (4 < Random.Range(0, 10))
            {
                rGrad = 1;
            }
            else
            {
                rGrad = 0;
            }
            
            Instantiate(grades[rGrad], spawnPos[rSpwan].transform.position, spawnPos[rSpwan].transform.rotation);
           
        }

        
    }
}
