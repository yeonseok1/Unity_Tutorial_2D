using UnityEngine;

public class Factory<T> : MonoBehaviour
{
    public T prefab;

    public Factory()
    {
        Debug.Log($"Factory�� {typeof(T)} Ÿ�� �Դϴ�.");
    }
}
