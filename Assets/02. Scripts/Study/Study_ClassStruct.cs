using UnityEngine;

public class Study_Class
{
    public int number;

    public Study_Class(int _num)
    {
        this.number = _num;
    }
}

public struct Study_Struct
{
    public int number;

    public Study_Struct(int _num)
    {
        this.number = _num;
    }
}


public class Study_ClassStruct : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Ŭ����----------");
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1;
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}");

        c1.number = 100;
        Debug.Log($"c1 : {c1.number} / c2 : {c2.number}");


        Debug.Log("����ü----------");
        Study_Struct s1 = new Study_Struct(10);
        Study_Struct s2 = s1;
        Debug.Log($"s1 : {s1.number} + / s2 : {s2.number}");

        s1.number = 1000;
        Debug.Log($"s1 : {s1.number} + / s2 : {s2.number}");
    }
}
