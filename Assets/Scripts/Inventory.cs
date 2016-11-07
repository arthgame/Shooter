using UnityEngine;
using UnityEngine.UI;
using System;

public class Inventory : MonoBehaviour {

    public Item[] items;
    public Text text;

    private bool isFull = false;
    private int currentIndex = 0;

    public bool IsFull()
    {
        return isFull;
    }

    public void PutItem(Item item)
    {
        CheckFirstEmptySlot();
        if (currentIndex == items.Length - 1)
            isFull = true;

        if (currentIndex < items.Length)
        {
            items[currentIndex] = item;
            text.text = items[currentIndex].nameOfItem;
        }
        else
            text.text = "Inventory is full";
    }

    public int CountItems()
    {
        int numberOfItems = 0;
        for (int i = 0; i < items.Length; i++)
            if (items[i])
                numberOfItems++;
        return numberOfItems;
    }

    private void CheckFirstEmptySlot()
    {
        for (int i = 0; i < items.Length; i++)
            if (!items[i])
            {
                currentIndex = i;
                return;
            }
        currentIndex = items.Length;
        Debug.Log("Inventory is full");
    }
}
