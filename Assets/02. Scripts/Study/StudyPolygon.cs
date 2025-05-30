using UnityEngine;

public class StudyPolygon : MonoBehaviour
{
    void Start()
    {
        Mesh mesh = new Mesh();

        Vector3[] vertices = new Vector3[]  // �� 4�� ���
        {
            new Vector3(0, 0, 0),
            new Vector3(1, 0, 0),
            new Vector3(0, 1, 0),
            new Vector3(1, 1, 0)
        };

        int[] triangles = new int[] // �ﰢ�� ����
        {
            0, 2, 1,
            2, 3, 1
        };

        Vector2[] uv = new Vector2[]    // ���� ����
        {
            new Vector2(0, 0),
            new Vector2(1, 0),
            new Vector2(0, 1),
            new Vector2(1, 1)
        };

        // Mesh�� ������ ���� ��, �ﰢ�� ����, uv �����͸� ����
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uv;

        // MeshFilter�� Mesh �����͸� ����
        MeshFilter meshFilter = this.gameObject.AddComponent<MeshFilter>();
        meshFilter.mesh = mesh;

        // MeshRenderer�� Material �����͸� ����
        MeshRenderer meshRenderer = this.gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = new Material(Shader.Find("Sprites/Default"));



    }

    void Update()
    {
        
    }
}
