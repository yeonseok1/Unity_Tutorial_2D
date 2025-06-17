using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    SpriteRenderer sRenderer;

    [SerializeField] protected float hp = 3f;
    [SerializeField] protected float moveSpeed = 3f;
    int dir = 1;

    public abstract void Init();

    private void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();

        Init();
    }

    void Update()
    {
        Movement();
    }

    void OnMouseDown()
    {
        Hit(1);
    }

    void Movement()
    {
        transform.position += Vector3.right * moveSpeed * dir * Time.deltaTime;

        if (transform.position.x > 8f)
        {
            dir = -1;
            sRenderer.flipX = true;
        }
        else if (transform.position.x < -8f)
        {
            dir = 1;
            sRenderer.flipX = false;
        }
    }

    void Hit(float damage)
    {
        hp -= damage;

        if ( hp <= 0)
        {
            Debug.Log("몬스터 죽음");
            Destroy(gameObject);
        }
    }

    /*
    public string name;
    public float damage;
    public float hp;

    private void Start()
    {
        Monster m1 = new Monster();
        Monster m2 = new Monster();
        Monster m3 = new Monster();
        Monster m4 = new Monster();
    }


    public Monster(string name, float damage, float hp)
    {
        this.name = name;
        this.damage = damage;
        this.hp = hp;
    }
    public Monster()
    {
        this.name = "슬라임";
        this.damage = 1;
        this.hp = 1;
    }
    public Monster(string name)
    {
        this.name = name;
        this.damage = 1;
        this.hp = 1;
    }
    public Monster (string name, float damage)
    {
        this.name = name;
        this.damage = damage;
        this.hp = 1;
    }
    */
}
