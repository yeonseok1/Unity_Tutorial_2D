using System;
using UnityEngine;

public class Study_Casting : MonoBehaviour
{
    private void Start()
    {
    //    Monster m = new Monster();

    //    // Orc o1 = m; // 암시적 형변환 X
    //    // Orc o = (Orc)m; // 명시적 형변환 -> 에러

    //    Orc o = m as Orc; // 성공시 형변환 / 실패시 null

    //    if (o != null)
    //    {
    //        Debug.Log(o);
    //    }
    //    else
    //    {
    //        Debug.Log("형변환 되지 않음");   // 다운캐스팅 실패
    //    }
    }


    void PracCasting01()
    {
        int num1 = 1;
        float num2 = 1.99f;


        num1 = (int)num2;
        Debug.Log(num1);

        // 수학적 방법
        float num4 = Mathf.Floor(num2);
        float num5 = Mathf.Ceil(num2);
        float num6 = Mathf.Round(num2);

        Debug.Log($"Floor   내림  : {num4}");
        Debug.Log($"Ceil    올림  : {num5}");
        Debug.Log($"Round   반올림 : {num6}");
    }

    void PracCasting02()
    {
        string str1 = "123";
        string str2 = "456";

        string str3 = str1 + str2;
        Debug.Log(str3);

        int num1 = int.Parse(str1);
        int num2 = int.Parse(str2);
        Debug.Log(num1 + num2);
    }

    void PracCasting03()
    {
        int num0 = 0;
        int num1 = 1;
        int num2 = 2;
        int num100 = 100;

        float fnum0 = 0f;
        float fnum1 = 1.57f;
        float fnum2 = 3.14f;

        //string str1 = "안녕하세요";
        string str2 = "true";
        string str3 = "false";


        Debug.Log("num0 : " + Convert.ToBoolean(num0));
        Debug.Log("num1 : " + Convert.ToBoolean(num1));
        Debug.Log("num2 : " + Convert.ToBoolean(num2));
        Debug.Log("num100 : " + Convert.ToBoolean(num100));

        Debug.Log("fnum0 : " + Convert.ToBoolean(fnum0));
        Debug.Log("fnum1 : " + Convert.ToBoolean(fnum1));
        Debug.Log("fnum2 : " + Convert.ToBoolean(fnum2));

        Debug.Log("str2 : " + Convert.ToBoolean(str2));
        Debug.Log("str3 : " + Convert.ToBoolean(str3));
        // Debug.Log("str1 : " + Convert.ToBoolean(str1)); // sring -> bool 은 에러
    }
}
