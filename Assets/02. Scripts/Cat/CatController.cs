using UnityEngine;
using Cat;

public class CatController : MonoBehaviour
{
    public SoundManager soundManager;

    public GameObject gameOverUI;
    public GameObject fadeUI;

    public GameObject happyVideo;
    public GameObject sadVideo;

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
        if (Input.GetKeyDown(KeyCode.Space) && (jumpCount < 1000))
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Apple"))
        {
            other.gameObject.SetActive(false);

            other.transform.parent.GetComponent<ItemEvent>().particle.SetActive(false);
            other.transform.parent.GetComponent<ItemEvent>().particle.SetActive(true);

            GameManager.score++;

            if (GameManager.score >= 10)
            {
                fadeUI.SetActive(true);
                fadeUI.GetComponent<FadeRoutine>().OnFade(2f, true, Color.white);
                this.GetComponent<CircleCollider2D>().enabled = false;

                Invoke("HappyVideo", 5f);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
            isGround = true;
            anim.SetTrigger("OnGround");
        }
        if (other.gameObject.CompareTag("Pipe"))
        {
            soundManager.OnColliderSound();

            gameOverUI.SetActive(true);
            fadeUI.SetActive(true);
            fadeUI.GetComponent<FadeRoutine>().OnFade(2f, true, Color.black);
            this.GetComponent<CircleCollider2D>().enabled = false;

            Invoke("SadVideo", 5f);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }

    private void HappyVideo()
    {
        happyVideo.SetActive(true);
        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }

    private void SadVideo()
    {
        sadVideo.SetActive(true);
        fadeUI.SetActive(false);
        gameOverUI.SetActive(false);

        soundManager.audioSource.mute = true;
    }
}
