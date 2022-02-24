using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpPower;
    public int extraJump;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Transform feet;


    public Text NumberOfJumpText;

    private bool ModePc = false;


    public bool thePower;

    public int jumpCount = 0;
    public bool isGrounded;
    float mx;
    float jumpCoolDown;

    private int extraJumpBack;
    private float speedBack;

    static public bool canShoot = false;

    bool facingRight = true;

    public AudioSource jumpSound;

    private void Awake()
    {

            canShoot = false;
        
    }
    private void Start()
    {
        NumberOfJumpText.text = "JUMP:" + 1;
    }
    private void Update()
    {
        if(ModePc)
        {
            mx = Input.GetAxis("Horizontal");
        }
        else
        {
            mx = CrossPlatformInputManager.GetAxis("Horizontal");
        }

 
        if (CrossPlatformInputManager.GetButtonDown("Jump")||Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        CheckGrounded();

        if(mx<0 && facingRight)
        {
            flip();
        }
        else if(mx>0 && !facingRight)
        {
            flip();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            thePower = !thePower;
            if (thePower)
            {
            extraJumpBack = extraJump;
            speedBack = speed;
            extraJump = 10000;
            speed = 10;
            }
            else
            {
                extraJump = extraJumpBack;
                speed = speedBack;
            }
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            ModePc = true;
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(mx * speed, rb.velocity.y);
        //rb.velocity = new Vector2((mx * speed - rb.velocity.x) * rb.mass / Time.fixedDeltaTime, 0);
    }
    void Jump ()
    {
        if(isGrounded || jumpCount < extraJump)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            jumpCount++;
            jumpSound.Play();
            
        }
    }
    void CheckGrounded()
    {
        if(Physics2D.OverlapCircle(feet.position, 0.3f, groundLayer))
        {
            isGrounded = true;
            jumpCount = 0;
            jumpCoolDown = Time.time + 0.2f;
        
        }
        else if (Time.time < jumpCoolDown)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    
    
    
    
    }

    void flip()
    {
        facingRight = !facingRight; 
        transform.Rotate(0f, 180f, 0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "JumpPowerUp")
        {
            extraJump ++;
            NumberOfJumpText.text ="JUMP:"+ (1 + extraJump);
        }
        if (other.tag == "ShotPower")
        {
            canShoot = true;
        }

        
    }

}