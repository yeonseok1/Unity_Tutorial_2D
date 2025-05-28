using UnityEngine;

public class ColliderEvent : MonoBehaviour
{
    // 상호작용하는 둘 중 하나라도 inTrigger == false 인 경우 호출
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision Enter");
    }



    // 상호작용하는 둘 중 하나라도 inTrigger == true 인 경우 호출
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTrigger Enter");
    }
}
