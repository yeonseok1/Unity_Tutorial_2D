using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int num1, num2;

    void Start()
    {
        int addResult = AddMethod();

        int minusResult = MinusMethod();

        Debug.Log($"더한 값 : {addResult} / 뺸 값 : {minusResult}");
    }

    int AddMethod()
    {
        int result = num1 + num2;

        return result;
    }

    int MinusMethod()
    {
        int result = num1 - num2;

        return result;
    }
}
