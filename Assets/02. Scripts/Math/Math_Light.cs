using UnityEngine;

public class Math_Light : MonoBehaviour
{
    new Light light;
    float theta;
    [SerializeField] float power;
    [SerializeField] float speed;

    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        theta += Time.deltaTime * speed;


        //light.intensity = Mathf.Sin(theta) * power;

        light.intensity = Mathf.PerlinNoise(theta, 0) * power;
    }
}
