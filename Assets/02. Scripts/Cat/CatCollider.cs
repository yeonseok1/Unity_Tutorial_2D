using UnityEngine;

public class CatCollider : MonoBehaviour
{
    public GameObject fadeUI;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            fadeUI.SetActive(true);
            Debug.Log("Game Over");


        }
    }

}
