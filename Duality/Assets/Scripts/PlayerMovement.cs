using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  
    //Main Character Stuff
    public Sprite agile;
    public Sprite brute;
    public float timeToDestroy = 0.25f;
    private bool agileActive = true;
    private SpriteRenderer spriteRenderer;
    private Animator anim;
    
    //Movement Vars
    public float fallMultiplier = 3f;
    public float jumpForce;
    private Rigidbody2D rb;


    public GameObject gameOverUI;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        spriteRenderer.sprite = agile;
    }

    void Update()
    {
        //Character Shift Begins
         if(Input.GetKeyDown(KeyCode.Space))
        {
            if(agileActive == true)
            { 
                spriteRenderer.sprite = brute;
                anim.SetBool("bruteActive", true);
                agileActive = false;
            }else
            {
              spriteRenderer.sprite = agile;
              anim.SetBool("bruteActive", false);
              agileActive = true;
            }
        }
        //Character Shift Ends

        //Movement
        if(rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier -1) * Time.deltaTime;
        }
        if(rb.velocity.y != 0)
        {
            anim.SetBool("isJump", true);
        }else
            anim.SetBool("isJump", false);
        }


    void OnTriggerEnter2D(Collider2D collider)
    {
        GameObject GO;
        if(collider.gameObject.CompareTag("Obstacle"))
        {
            if(agileActive)
            {
                rb.velocity += Vector2.up * jumpForce;
            }else
            Die();
        }

        if(collider.gameObject.CompareTag("Enemy"))
        {
            if(agileActive)
            {
                Die();
            }else
            {
                GO = collider.gameObject;
                GO.GetComponent<Enemy>().Kill();
            }
        }
    }
    void Die()
    {
        gameOverUI.SetActive(true);
        Destroy(gameObject, timeToDestroy);
    }
}
