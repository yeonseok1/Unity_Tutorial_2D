using UnityEngine;

public class Study_Foreach : MonoBehaviour
{
    public string[] persons = new string[5] { "ö��", "����", "����", "����Ŭ", "��" };
    public string findName;

    void Start()
    {
        FindPerson(findName);
    }

    private void FindPerson(string name)
    {
        bool isFind = false;
        foreach (var person in persons)
        {
            if (person == name)
            {
                isFind = true;
                Debug.Log($"�ο� �߿� {name}�� �����մϴ�.");
            }
        }

        if (!isFind)
            Debug.Log($"{name}�� ã�� ���߽��ϴ�.");
    }
}
