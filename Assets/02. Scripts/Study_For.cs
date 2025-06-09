using System.Collections.Generic;
using UnityEngine;

public class Study_For : MonoBehaviour
{
    public List<int> listInt = new List<int>();

    void Start()
    {
        for (int i = 0; i < listInt.Count; i++)
        {
            Debug.Log(listInt[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
