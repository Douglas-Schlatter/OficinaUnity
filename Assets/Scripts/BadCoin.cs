using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadCoin : MonoBehaviour
{

    public bool isCath = false;

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.tag);
        if (col.tag == "Player" && !isCath)
        {
            isCath = true;

            FindObjectOfType<AudioManager>().Play("bad");
            if (col.GetComponent<Player>().canGetHit)
            {
                col.GetComponent<Player>().canGetHit = false;
                col.GetComponent<Player>().life--;
            }
            
            Destroy(this.gameObject);
        }
        else if (col.tag == "Ground" && !isCath)
        {
            isCath = true;
            Destroy(this.gameObject);
        }

    }
}
