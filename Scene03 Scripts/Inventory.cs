using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<BlockItem> blockItems;

    public void Pickup(string itemName)
    {
        BlockItem blockItem = FindBlockItem(itemName);
        if (blockItem != null)
        {
            blockItem.quantity++;
        }
    }

    public GameObject Place(string itemName)
    {
        BlockItem blockItem = FindBlockItem(itemName);
        if (blockItem != null && blockItem.quantity > 0)
        {
            blockItem.quantity--;
            return blockItem.prefab;
        }
        else
        {
            return null;
        }
    }

    private BlockItem FindBlockItem(string itemName)
    {
        foreach(BlockItem blockItem in blockItems)
        {
            if (blockItem.name == itemName)
            {
                return blockItem;
            }
        }
        return null;
    }
}
