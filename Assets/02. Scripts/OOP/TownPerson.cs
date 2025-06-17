using UnityEngine;

public class TownPerson : MonoBehaviour, IMove
{
    public float hp;
    public float spd;

    public void Move()
    {
        Debug.Log("Move");
        transform.position += transform.right * spd * Time.deltaTime;
    }
}
