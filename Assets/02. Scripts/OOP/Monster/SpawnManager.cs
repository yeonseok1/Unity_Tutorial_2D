using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] monsters;   // 몬스터 종류가 이미 정해진 상태

    [SerializeField] GameObject[] items;

    // n초 마다 몬스터를 랜덤으로 생성하는 기능

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);

            var randomIndex = Random.Range(0, monsters.Length);
            var randomX = Random.Range(-8, 9);
            var randomY = Random.Range(-3, 5);

            var createPos = new Vector3(randomX, randomY, 0);

            Instantiate(monsters[randomIndex], createPos, Quaternion.identity);
        }
    }

    public void DropCoin(Vector3 dropPos)
    {
        var randomIndex = Random.Range(0, items.Length);

        GameObject item = Instantiate(items[randomIndex], dropPos, Quaternion.identity);
        Rigidbody2D itemRb = item.GetComponent<Rigidbody2D>();

        itemRb.AddForceX(Random.Range(-2f, 2f), ForceMode2D.Impulse);
        itemRb.AddForceY(5, ForceMode2D.Impulse);

        float ranPower = Random.Range(-0.1f, 0.1f);
        itemRb.AddTorque(ranPower, ForceMode2D.Impulse);

    }
}
