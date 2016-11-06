using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

    public string nameOfItem;

    private bool isInInventory;

    public bool IsInInventory()
    {
        return isInInventory;
    }

    public void IsInInventory(bool itemInInventory)
    {
        isInInventory = itemInInventory;
    }
}
