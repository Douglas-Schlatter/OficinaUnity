using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    // Use this for initialization
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
        if (timer - lSpawn > 1)
        {
            lSpawn = timer;
            target = Random.Range(0, 4);

            Instantiate(coin, spawnPos[target].transform.position, spawnPos[target].transform.rotation);
        }

        
    }
}
