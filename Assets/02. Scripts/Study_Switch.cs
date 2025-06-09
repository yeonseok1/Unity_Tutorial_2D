using UnityEngine;

public class Study_Switch : MonoBehaviour
{
    public enum Calc_Type { PLUS, MINUS, MULTIPLY, DIVIDE }
    public Calc_Type calcType = Calc_Type.PLUS;

    public int input1, input2, result;

    void Start()
    {
        Calculation();
        Debug.Log($"계산 결과 : {Calculation()}");
    }

    int Calculation()
    {
        int value = 0;

        switch (calcType)
        {
            case Calc_Type.PLUS:
                result = input1 + input2;
                break;
            case Calc_Type.MINUS:
                result = input1 - input2;
                break;
            case Calc_Type.MULTIPLY:
                result = input1 * input2;
                break;
            case Calc_Type.DIVIDE:
                result = input1 / input2;
                break;

        }

        return value;
    }
}
