using UnityEngine;

public class Item_Coin : MonoBehaviour, IItem
{
    Inventory inventory;
    public enum CoinType { GOLD, RED }
    public CoinType coinType;

    public float price;

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
        inventory.AddItem(this);
        gameObject.SetActive(false);
    }

}
