using UnityEngine;

public class Pipe_Loop : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float returnPosX = 15f;
    public float randomPosY;

    private void Start()
    {
        randomPosY = Random.Range(-7, -3);

        transform.position = new Vector3(transform.position.x, randomPosY, 0);
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= -returnPosX)
        {
            randomPosY = Random.Range(-7f, -3f);
            transform.position = new Vector3(returnPosX, randomPosY, 0);
        }
    }
}