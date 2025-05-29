using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //this.transform.position += Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        /*
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        */  // legacy input system

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Vector3 nomalDir = dir.normalized;


        transform.position += nomalDir * (moveSpeed * Time.deltaTime);

        transform.LookAt(transform.position + nomalDir);
        
    }
}
