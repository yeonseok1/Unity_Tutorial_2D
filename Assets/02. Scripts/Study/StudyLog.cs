using UnityEngine;

public class StudyLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start �Լ� ����");
        Debug.LogWarning("Start �Լ� ����");
        Debug.LogError("Start �Լ� ����");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update �Լ� ����");
    }
}
