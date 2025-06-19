using UnityEngine;

public class Math_triCircle : MonoBehaviour
{
    public float Degree;
    public float theta;
    public float Radius = 2;


    void Start()
    {
        
    }

    void Update()
    {
        Degree += Time.deltaTime;

        theta = Degree * Mathf.Deg2Rad;

        float x = Mathf.Cos(theta);
        float y = Mathf.Sin(theta);

        Vector2 pos = new Vector2(x, y) * Radius;

        transform.position = pos;
    }
}
