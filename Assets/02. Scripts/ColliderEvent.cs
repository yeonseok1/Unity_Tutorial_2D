using UnityEngine;

public class ColliderEvent : MonoBehaviour
{
    // ��ȣ�ۿ��ϴ� �� �� �ϳ��� inTrigger == false �� ��� ȣ��
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision Enter");
    }



    // ��ȣ�ۿ��ϴ� �� �� �ϳ��� inTrigger == true �� ��� ȣ��
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTrigger Enter");
    }
}
