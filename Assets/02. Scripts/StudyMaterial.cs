using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    public Material mat;

    void Start()
    {
        // this.GetComponent<Material>() = mat; <- ����

        // this.GetComponent<MeshRenderer>().material = mat;

        // this.GetComponent<MeshRenderer>().sharedMaterial = mat;

        this.GetComponent<MeshRenderer>().material.color = Color.white;

        // this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.white; // �����ϴ� ���������ͱ��� ����

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
