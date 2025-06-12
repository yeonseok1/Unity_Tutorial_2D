using UnityEngine;
using Cat;
using System.Collections;

public class CatController : MonoBehaviour
{
    public SoundManager soundManager;
    public VideoManager videoManager;

    public GameObject gameOverUI;
    public GameObject fadeUI;

    private Rigidbody2D catRb;
    private Animator anim;

    public float jumpPower = 15f;
    public bool isGround = false;

    public int jumpCount = 0;


    void Awake()
    {
        catRb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        transform.localPosition = Vector3.zero;

        transform.localPosition = new Vector3 (-7f, 0f, 0f);

        GetComponent<CircleCollider2D>().enabled = true;
        soundManager.audioSource.Play();

    }

    void Update()
    {
        Jump();
    }

    void Jump()
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
                fadeUI.GetComponent<FadeRoutine>().OnFade(2f, Color.white, true);
                this.GetComponent<CircleCollider2D>().enabled = false;

                //Invoke("HappyVideo", 5f);
                StartCoroutine(EndingRoutine(true));
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
            fadeUI.GetComponent<FadeRoutine>().OnFade(2f, Color.black, true);
            this.GetComponent<CircleCollider2D>().enabled = false;

            //Invoke("SadVideo", 5f);
            StartCoroutine(EndingRoutine(false));
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }

    IEnumerator EndingRoutine(bool isHappy)
    {
        yield return new WaitForSeconds(3.5f);

        videoManager.VideoPlay(isHappy);
        gameOverUI.SetActive(false);
        //soundManager.audioSource.mute = true;
        soundManager.audioSource.Stop();

        yield return new WaitForSeconds(0.5f);

        var newColor = isHappy ? Color.white : Color.black;
        fadeUI.GetComponent<FadeRoutine>().OnFade(3f, newColor, false);

        yield return new WaitForSeconds(3f);
        fadeUI.SetActive(false);
        

        transform.parent.gameObject.SetActive(false);
    }

    //private void HappyVideo()
    //{
    //    videoManager.VideoPlay(true);

    //    fadeUI.SetActive(false);
    //    gameOverUI.SetActive(false);

    //    soundManager.audioSource.mute = true;
    //}

    //private void SadVideo()
    //{
    //    videoManager.VideoPlay(false);

    //    fadeUI.SetActive(false);
    //    gameOverUI.SetActive(false);

    //    soundManager.audioSource.mute = true;
    //}
}
