using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Rigidbody2D carRb;
    private float h;

    void Update()
    {
        h = Input.GetAxis("Horizontal");

        // Transform 이동
        // transform.position += Vector3.right * h * moveSpeed * Time.deltaTime;
    }

    void FixedUpdate()
    {
        // Rigidbody 이동
        carRb.linearVelocityX = h * moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log(other.gameObject.name);
        Debug.Log("C_Enter");
        //other.gameObject.SetActive(false);
    }

    void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("C_Stay");
    }

    void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("C_Exit");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("T_Enter");
    }
    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("T_Stay");
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("T_Exit");
    }

}