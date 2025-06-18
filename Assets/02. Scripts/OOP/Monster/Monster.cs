using System.Collections;
using UnityEngine;

public abstract class Monster : MonoBehaviour
{
    [SerializeField] SpawnManager spawner;
    SpriteRenderer sRenderer;
    Animator animator;

    [SerializeField] protected float hp = 3f;
    [SerializeField] protected float moveSpeed = 3f;
    int dir = 1;
    bool isMove = true;
    private bool isHit = false;

    public abstract void Init();

    private void Start()
    {
        spawner = FindFirstObjectByType<SpawnManager>();

        sRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        Init();
    }

    void Update()
    {
        Movement();
    }

    void OnMouseDown()
    {
        //if (isHit) return;
        StartCoroutine(Hit(1));
    }

    void Movement()
    {
        if (!isMove) return;

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

    IEnumerator Hit(float damage)
    {
        if (isHit) 
            yield break;
        isHit = true;
        isMove = false;
        animator.SetTrigger("Hit");

        hp -= damage;

        yield return new WaitForSeconds(0.2f);
        if (hp <= 0)
        {
            animator.SetTrigger("Death");
            yield return new WaitForSeconds(0.5f);

            spawner.DropCoin(transform.position);

            yield return new WaitForSeconds(0.5f);

            Destroy(gameObject);
        }
        yield return new WaitForSeconds(0.2f);

        isMove = true;
        isHit = false;
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
        this.name = "½½¶óÀÓ";
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
