using Unity.VisualScripting;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    public GameObject obj;
    public GameObject destroyObj;

    public Vector3 pos;
    public Quaternion rot;

    public string name_obj;

    void Awake()
    {
        obj = CreateAmongus(name_obj);
    }

    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            Destroy(destroyObj, 3f);
            Destroy(obj, 3f);
            Debug.Log("3�� �� �ı��մϴ�");
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("������ �����մϴ�");
        }
    }

    void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}�� �ı��Ǿ����ϴ�.");
    }

    public GameObject CreateAmongus(string _name = "dofault")
    {
        Debug.Log("�����Ǿ����ϴ�");
        GameObject _obj = Instantiate(prefab, pos, rot);
        _obj.name = _name;


        Transform objTf = _obj.transform;
        int count = objTf.childCount;

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {count}");

        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(0).name}");

        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {objTf.GetChild(count - 1).name}");

        return _obj;
    }
}
