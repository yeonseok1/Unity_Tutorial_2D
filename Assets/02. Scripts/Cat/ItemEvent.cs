using UnityEngine;

public class ItemEvent : MonoBehaviour
{
    public enum ColliderType { PIPE, APPLE, BOTH }
    public ColliderType colliderType;
    
    public GameObject pipe;
    public GameObject apple;
    public GameObject particle;

    public float moveSpeed = 3f;
    public float returnPosX = 15f;
    public float randomPosY;

    private Vector3 initPos;

    void Awake()
    {
        initPos = transform.localPosition;
        //SetItem(transform.position.x);
        //randomPosY = Random.Range(-7, -3);
        //transform.position = new Vector3(transform.position.x, randomPosY, 0);
    }

    private void OnEnable()
    {
        SetItem(initPos.x);
    }

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= -returnPosX)
        {
            SetItem(returnPosX);
            //randomPosY = Random.Range(-7f, -3f);
            //transform.position = new Vector3(returnPosX, randomPosY, 0);
        }
    }

    void SetItem(float posX)
    {
        randomPosY = Random.Range(-7f, -3f);
        transform.position = new Vector3(posX, randomPosY, 0);

        pipe.SetActive(false);
        apple.SetActive(false);
        particle.SetActive(false);

        colliderType = (ColliderType)Random.Range(0, 3); // (int)로 명시적 형변환
        
        switch (colliderType)
        {
            case ColliderType.PIPE:
                pipe.SetActive(true);
                break;
            case ColliderType.APPLE:
                apple.SetActive(true);
                break;
            case ColliderType.BOTH:
                pipe.SetActive(true);
                apple.SetActive(true);
                break;
        }
    }
}
