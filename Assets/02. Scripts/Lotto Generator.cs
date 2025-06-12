using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LottoGenerator : MonoBehaviour
{
    //public int[] intArray = new int[10];
    public List<int> intList = new List<int>();
    public int shakeCount = 100;
    public float spd_Shuffle = 0.01f;

    void Awake()
    {
        for (int i = 1; i < 46; i++)
        {
            intList.Add(i);
        }

    }

    IEnumerator Start()
    {
        for (int i = 0; i < shakeCount; i++)
        {
            int ranInt1 = Random.Range(0, intList.Count);
            int ranInt2 = Random.Range(0, intList.Count);

            var temp = intList[ranInt1];
            intList[ranInt1] = intList[ranInt2];
            intList[ranInt2] = temp;

            yield return null;
        }

        List<int> resultGroup = new List<int>();

        for (int i = 0; i < 6; i++)
        {
            resultGroup.Add(intList[i]);
        }
        
        resultGroup.Sort();

        string resultNumber = $"�̹� �� �ζ� ��ȣ : {resultGroup[0]} / {resultGroup[1]} / {resultGroup[2]} / {resultGroup[3]} / {resultGroup[4]} / {resultGroup[5]} / ���ʽ� �ѹ� : {intList[6]}";

        Debug.Log(resultNumber);
    }
}
