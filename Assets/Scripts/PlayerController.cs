using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    public float speed;
    public float jumpForce;

    // Stuff for making sure player is on the ground
    [Header("Grounding")]
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;

    private int facingDirection = 1;

    private float horizontal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("horizontal", Mathf.Abs(horizontal));

        if (horizontal > .1f && facingDirection < 0 || horizontal < -.1f && facingDirection > 0)
        {
            Flip();
        }

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            animator.SetTrigger("jump");
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocity.y);
    }

    bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }

    void Flip()
    {
        facingDirection *= -1;

        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
