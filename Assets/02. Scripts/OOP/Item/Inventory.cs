using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    public List<GameObject> Items = new List<GameObject>();

    public void AddItem(IItem item)
    {
        Items.Add(item.Obj);
    }
}
