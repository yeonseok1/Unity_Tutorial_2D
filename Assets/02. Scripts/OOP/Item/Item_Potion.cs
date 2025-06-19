using UnityEngine;

public class Item_Potion : MonoBehaviour
{
    Inventory inventory;
    public enum PotionType { HP, MP, GOLD }
    public PotionType potionType;

    private void Start()
    {
        inventory = FindFirstObjectByType<Inventory>();
        Obj = gameObject;
    }

    public GameObject Obj { get; set; }

    private void OnMouseDown()
    {
        Get();
    }

    public void Get()
    {
        gameObject.SetActive(false);
    }
}
