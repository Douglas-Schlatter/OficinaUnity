using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    //Move related
    public Rigidbody2D rb;
    public int moveSpeed = 10;
    Vector2 movement;

    //Score related
    public int score;


    //Text related
    public Text scoreDisplay;
    //public Text lifeDisplay;

    //life display related 
    public Image Vida1;
    public Image Vida2;
    public Image Vida3;
    public Sprite CoraçãoCheio;
    public Sprite CoraçãoVazio;


    //Status Effects
    public int life = 3;
    public bool canGetHit = true;
    //Time Related
    public float timer = 0.0f;
    public float lastHitSnap = -2.0f;

    //Anime related
    public Animator anim;
    public bool facRi = true;

    void Update () 
    {
        anim.SetFloat("Speed", Mathf.Abs(moveSpeed * Input.GetAxis("Horizontal")));
        Debug.Log(Input.GetAxis("Horizontal"));
        
        if (Input.GetAxis("Horizontal") > 0 && !facRi)
        {
            Flip();
        }
        
        if (Input.GetAxis("Horizontal")< 0 && facRi)
        {
            Flip();
        }

        if (life == 3)
        {
            Vida3.sprite = CoraçãoCheio;
            Vida2.sprite = CoraçãoCheio;
        }
        if (life == 2)
        {
            Vida3.sprite = CoraçãoVazio;
            Vida2.sprite = CoraçãoCheio;
        }
        else if (life == 1)
        {
            Vida2.sprite = CoraçãoVazio;
        }


    }
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if ((timer - lastHitSnap) > 2.0)
        {
            canGetHit = true;
        }
        scoreDisplay.text = score.ToString();
        //lifeDisplay.text = life.ToString();
        if (life <= 0)
        {
            SceneManager.LoadScene(0);
        }

        movement.x = Input.GetAxis("Horizontal"); // sugestão da namorada fazer um dicionario, ex input = entrada
        rb.MovePosition(rb.position + moveSpeed * movement * Time.deltaTime);
    }

    public void Flip()
    {
        Vector3 currScale = gameObject.transform.localScale;
        currScale.x *= -1;
        gameObject.transform.localScale = currScale;
        facRi = !facRi;

    }

}
