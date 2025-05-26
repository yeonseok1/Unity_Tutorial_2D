using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed;
    public bool isStop; // false
    public float stopSpeed = 10f;

    void Start()
    {
        rotSpeed = 0f;
    }

    void Update()
    {
        /// Vector3.forward = new Vector3(0f, 0f, 1)
        // transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime * -1);
        transform.Rotate(0f, 0f, rotSpeed * Time.deltaTime * -1);

        if (Input.GetMouseButton(0))
        {
            rotSpeed = 600f;
            isStop = false;
        }

        if (rotSpeed > 0f)
        {
            rotSpeed -= 1;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

        if (isStop == true)
        {
            rotSpeed -= stopSpeed;
        }


        if (rotSpeed < 0f) rotSpeed = 0f;

    }
}
