using Unity.VisualScripting;
using UnityEngine;

public class Study_Invoke : MonoBehaviour
{
    public int count = 10;

    void Start()
    {
        InvokeRepeating("Bomb", 0f, 1f);
    }

    private void Bomb()
    {
        Debug.Log($"���� ���� �ð� : {count}��");
        count--;

        if (count == 0)
        {
            Debug.Log("��ź�� �������ϴ�.");
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CancelInvoke("Bomb");
            Debug.Log("��ź�� �����Ǿ����ϴ�.");
        }
    }
}