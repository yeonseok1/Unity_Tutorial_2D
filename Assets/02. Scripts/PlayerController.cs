using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;
    [SerializeField] GameObject hitBox;
    [SerializeField] float moveSpeed = 3f;
    float h, v;
    bool isAttack = false;
    public float Atk = 1;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
        Anim();
        Attack();
    }

    void Move()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        var dir = new Vector3(h, v, 0).normalized;

        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    void Anim()
    {
        if (h == 0 && v == 0)
        {
            animator.SetBool("Run", false);
        }
        else
        {
            int scaleX = h > 0 ? 1 : -1;

            transform.localScale = new Vector3(scaleX, 1, 1);

            animator.SetBool("Run", true);

        }

    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isAttack)
        {
           StartCoroutine(AttackRoutine());
        }
    }

    IEnumerator AttackRoutine()
    {
        isAttack = true;
        hitBox.SetActive(true);

        yield return new WaitForSeconds(0.25f);
        isAttack = false;
        hitBox.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Monster>() != null)
        {
            Monster monster = other.GetComponent<Monster>();
            StartCoroutine(monster.Hit(Atk));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)   // collision은 직접 컴퍼넌트를 바꿀 수 없다
    {
        if(other.gameObject.GetComponent<IItem>() != null)
        {
            IItem item = other.gameObject.GetComponent<IItem>();
            item.Get();
        }
    }
}
