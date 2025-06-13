using UnityEngine;

public class Study_Generic : MonoBehaviour
{
    void Start()
    {
        Factory<Monster> factory = new Factory<Monster>();
    }
}
