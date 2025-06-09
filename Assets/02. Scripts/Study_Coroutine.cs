using System.Collections;
using UnityEngine;

public class Study_Coroutine : MonoBehaviour
{
    private bool isStop = false;

    void Start()
    {
        StartCoroutine(BombRoutine());
    }

    IEnumerator BombRoutine()
    {
        int t = 10;
        while (t > 0)
        {
            Debug.Log($"{t}�� ���ҽ��ϴ�.");
            yield return new WaitForSeconds(1f);
            t--;

            if (isStop)
            {
                Debug.Log("��ź�� �����Ǿ����ϴ�.");
                yield break;
            }
        }

        Debug.Log("��ź�� �������ϴ�.");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }
    }

    //IEnumerator RoutineA()
    //{
    //    // yield return null;  // �� �� ������ ���
    //    yield return new WaitForSeconds(3);  // 3�� ���

    //    Debug.Log("�ڷ�ƾ ����");
    //}
}
