using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public bool isCath = false;
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.tag);
        if (col.tag == "Player" && !isCath)
        {
            isCath = true;

            col.GetComponent<Player>().score += 1;
            Destroy(this.gameObject);
        }
        else if (col.tag == "Ground" && !isCath)
        {
            isCath = true;
            Destroy(this.gameObject);
        }

    }
}
