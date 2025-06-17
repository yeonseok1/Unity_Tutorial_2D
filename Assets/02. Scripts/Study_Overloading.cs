using UnityEngine;

public class Study_Overloading : MonoBehaviour
{
    void Start()
    {
        Attack();
        Attack(true);
        Attack(10f);

        GameObject gameObject = new GameObject("����");
        Attack(10, gameObject);
    }

    public void Attack()
    {
        Debug.Log("����");
    }

    public void Attack(bool isMagic)
    {
        if (isMagic)
            Debug.Log("���� ����");
    }

    public void Attack(float damage)
    {
        Debug.Log($"{damage} ������ ��ŭ ����");
    }

    public void Attack(float damage, GameObject target)
    {
        Debug.Log($"{target.name}���� {damage} ������ ��ŭ ����");
    }
}
