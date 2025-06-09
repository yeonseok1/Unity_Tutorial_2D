using UnityEngine;

public class Coin : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Movement.coinCount++;
            Debug.Log("ÄÚÀÎ È¹µæ!! " + Movement.coinCount + "°³ È¹µæ");
            Destroy(gameObject);
        }
    }
}
