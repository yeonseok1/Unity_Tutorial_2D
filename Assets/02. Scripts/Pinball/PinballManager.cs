using UnityEngine;

public class PinballManager : MonoBehaviour
{
    public Rigidbody2D leftBarRb;
    public Rigidbody2D rightBarRb;

    public int totalScore = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            leftBarRb.AddTorque(100f);
        else
            leftBarRb.AddTorque(-80f);

        if (Input.GetKey(KeyCode.RightArrow))
            rightBarRb.AddTorque(-100f);
        else
            rightBarRb.AddTorque(80f);
    }
}
