using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float x_TileSize = 30f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if(transform.position.x <= -30f)
        {
            transform.position += new Vector3(x_TileSize * 2, 0, 0);
        }


    }
}
