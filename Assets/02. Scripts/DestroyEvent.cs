using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 3f;

    void Start()
    {
        Destroy(this.gameObject, destroyTime);
    }

    void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}�� �ı��Ǿ����ϴ�.");
    }
}
