using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public ScoreManager scoreManager;


    private bool facingRight = true;                
    private bool jump = false;

    private float Move;
    public float moveForce = 365f;
    public float maxSpeed = 5f;
    public float jumpForce = 1000f;
    public float bounceFactor = 1.25f;
    public float forceJumpLimit = 1700f;
    public float HorizontalJumpFactor = 100f;

    public ParticleSystem forceJumpEffect;
    public ParticleSystem moveParticle;

    public Transform groundCheck;


    private Animator animator;
    private Rigidbody2D rb2D;


    public bool isJumping;

    private void Awake()
    {

        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (isJumping == false)
            {
                rb2D.AddForce(new Vector2(rb2D.velocity.x, jumpForce));
            }

        }
        Move = Input.GetAxis("Horizontal");

        rb2D.velocity = new Vector2(maxSpeed * Move, rb2D.velocity.y);



    }



    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x = -1;
        transform.localScale = scale;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Platform")
        {
            scoreManager.UpdateScore((int)transform.position.y);
        } 

        if (col.gameObject.tag == "Wall")
        {
            Flip();
            Vector2 rev = new Vector2(rb2D.velocity.x * bounceFactor, 0);
            rb2D.AddForce(rev, ForceMode2D.Impulse);
        }
        if (col.gameObject.tag == "Platform")
        {

        }
        isJumping = false;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isJumping = true;
    }
}