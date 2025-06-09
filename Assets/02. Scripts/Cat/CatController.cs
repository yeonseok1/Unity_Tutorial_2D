using UnityEngine;
using Cat;

public class CatController : MonoBehaviour
{
    public SoundManager soundManager;

    private Rigidbody2D catRb;
    private Animator anim;

    public float jumpPower = 15f;
    public bool isGround = false;

    public int jumpCount = 0;


    void Start()
    {
        catRb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (jumpCount < 2))
        {
            catRb.AddForceY(jumpPower, ForceMode2D.Impulse);
            anim.SetTrigger("Jump");
            soundManager.OnJumpSound();
            jumpCount++;
        }

        var catRotation = transform.eulerAngles;
        catRotation.z = catRb.linearVelocityY * 2.5f;
        transform.eulerAngles = catRotation;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
            isGround = true;
            anim.SetTrigger("OnGround");
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }
}
