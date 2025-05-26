using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    void Start()
    {
        
    }

    void Update()
    {
        /// ���� �������� �̵��ϴ� ���
        // transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        /// ���� �������� �̵��ϴ� ���
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        /// ���� �������� ȸ��
        // transform.rotation = Quaternion.Euler(0f, transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime, 0f);

        /// ���� �������� ȸ��
        // transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);  //Space.self ����

        /// ���� �������� ȸ��
        // transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime, Space.World);

        /// Ư�� ��ġ�� �ֺ��� ȸ��
        transform.RotateAround(Vector3.zero, Vector3.up, rotateSpeed * Time.deltaTime);

        transform.LookAt(Vector3.zero);


    }
}
