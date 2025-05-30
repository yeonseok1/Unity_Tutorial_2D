using UnityEngine;

public class StudyCompnent : MonoBehaviour
{
    // public GameObject obj = new GameObject(); ¿Ã∞« æ» µ 
    public GameObject obj;

    public Mesh msh;
    public Material mat;

    public string objName;


    void Start()
    {
        //obj = GameObject.CreatePrimitive(PrimitiveType.Cube);

        CreateCube();
        CreateCube(objName);
    }

    public void CreateCube(string obj_name = "Cube")
    {
        //obj = new GameObject();
        //obj.name = "Cube";
        obj = new GameObject(obj_name);

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().sharedMaterial = mat;

        obj.AddComponent<BoxCollider>();
    }
}
