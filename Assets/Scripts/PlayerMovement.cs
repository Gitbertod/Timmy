using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float vertical;
    private float axisX;
    public float speed,jumpForce;
    public Rigidbody2D rb;
    public bool canJump,pause;
    public Transform groundCheck;
    public LayerMask layer;
    public GameObject player,MenuPausa, Message;
    private Animator Anim;
    

    void Start()
    {
        Anim = GetComponent<Animator>();
        
        
    }


    // Update is called once per frame
    void Update()
    {
        Anim.SetFloat("Speed",Mathf.Abs (rb.velocity.x));


        canJump = Physics2D.Linecast(player.transform.position, groundCheck.position, layer);
        Debug.DrawLine(player.transform.position,groundCheck.position);

        if (canJump)
        {
            Anim.SetBool("Jump", false);
        }
        else
        {
            Anim.SetBool("Jump", true);
        }   
        
       


        if (Input.GetKeyDown(KeyCode.A)) 
        {
            transform.localScale = new Vector3(-0.5f,transform.localScale.y,transform.localScale.z);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector3(0.5f, transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetKeyDown("w") && canJump)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
       
       //PAUSE SYSTEM 
        if(Input.GetKeyDown(KeyCode.Escape)&&pause)
        { 
                Time.timeScale = 0f;
                MenuPausa.SetActive(true);
            pause = (false);
        }
        else if(Input.GetKeyDown(KeyCode.Escape)&&pause==false)
        {
            Time.timeScale = 1f;
            MenuPausa.SetActive(false);
            pause = (true);
        }

        axisX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(axisX * speed, rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "platform") && (rb.velocity.y <= 0))
        {
            transform.parent = collision.transform;

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "platform")
        {
            transform.parent = null;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Message") 
        {
            Message.gameObject.SetActive(true);
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Message")
        {
            Message.gameObject.SetActive(false);
        }
    }





}

