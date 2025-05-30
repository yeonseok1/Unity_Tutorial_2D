using Unity.VisualScripting;
using UnityEngine;

public class Char_Mov : MonoBehaviour
{
    private Rigidbody2D characterRb;
    public SpriteRenderer[] renderers;

    public float moveSpeed = 6f;
    public float jumpSpeed = 14;
    float h;
    [SerializeField] int j;
    [SerializeField] int j_count;

    bool isGround;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = true;
            j_count = 2;
            j = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
            isGround = false;
    }

    void Start()
    {
        characterRb = GetComponent<Rigidbody2D>();

        renderers = GetComponentsInChildren<SpriteRenderer>(true);
    }


    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            j = 1;
        }
    }
    void FixedUpdate()
    {
        Move();
        Jump();
        OnSprite();
    }

    
    public void Move()
    {
        characterRb.linearVelocityX = h * moveSpeed;

        if (h < 0)
        {
            renderers[0].flipX = true;
            renderers[1].flipX = true;
            renderers[2].flipX = true;
        }
        else if (h > 0)
        {
            renderers[0].flipX = false;
            renderers[1].flipX = false;
            renderers[2].flipX = false;
        }
    }

    public void Jump()
    {
        if ((j > 0) && (j_count > 0))
        {
            characterRb.linearVelocityY = jumpSpeed;
            j_count--;
            j--;
        }
    }

    private void OnSprite()
    {
        renderers[0].gameObject.SetActive(h == 0 && isGround);  // Idle
        renderers[1].gameObject.SetActive(h != 0 && isGround);  // Run
        renderers[2].gameObject.SetActive(!isGround);           // Jump
    }
}
