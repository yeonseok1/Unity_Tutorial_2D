using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    public Material mat;

    void Start()
    {
        // this.GetComponent<Material>() = mat; <- 에러

        // this.GetComponent<MeshRenderer>().material = mat;

        // this.GetComponent<MeshRenderer>().sharedMaterial = mat;

        this.GetComponent<MeshRenderer>().material.color = Color.white;

        // this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.white; // 공유하는 원본데이터까지 변경

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
