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
            Debug.Log("3초 후 파괴합니다");
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("게임을 종료합니다");
        }
    }

    void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}이 파괴되었습니다.");
    }

    public GameObject CreateAmongus(string _name = "dofault")
    {
        Debug.Log("생성되었습니다");
        GameObject _obj = Instantiate(prefab, pos, rot);
        _obj.name = _name;


        Transform objTf = _obj.transform;
        int count = objTf.childCount;

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {count}");

        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {objTf.GetChild(0).name}");

        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {objTf.GetChild(count - 1).name}");

        return _obj;
    }
}
