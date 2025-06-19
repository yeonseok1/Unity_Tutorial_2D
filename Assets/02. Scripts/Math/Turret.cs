using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform turretHead;

    float theta;
    float rotSpeed = 1f;
    float rotRange = 60f;

    bool isTarget = false;
    public Transform target;

    void Update()
    {
        if (!isTarget)
            TurretIdle();
        else
            LookTarget();
    }

    void TurretIdle()
    {
        theta += Time.deltaTime * rotSpeed;
        float rotY = Mathf.Sin(theta) * rotRange;
        turretHead.localRotation = Quaternion.Euler(0, rotY, 0);
    }

    void LookTarget()
    {
        turretHead.transform.LookAt(target);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            target = other.transform;
            isTarget = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            target = null;
            isTarget = false;
        }
    }
}
