using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    //Move related
    public Rigidbody2D rb;
    public int moveSpeed = 10;
    Vector2 movement;

    //Score related
    public int score;
    public Text scoreDisplay;

	void Update () {
		
	}
    void FixedUpdate()
    {
        scoreDisplay.text = score.ToString();
        movement.x = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + moveSpeed * movement * Time.deltaTime);
    }

}
