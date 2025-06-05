using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int count = 0;
    public int maxCount = 10;
    public int stopCount = 8;


    void Start()
    {
        while (count < maxCount)
        {
            count++;

            if (count == stopCount + 1)
                break;

            if (count % 3 == 0)
            {
                Debug.Log("짝!");
                continue;
            }



            Debug.Log($"현재 {count}입니다.");
        }

    }

}
