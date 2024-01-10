using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] 
    string[] inventoryArray = new[] {"Sword", "Shield", "Potion"};

    [SerializeField] 
    List<string> inventoryList = new List<string>();
    
    void Start()
    {
        DisplayInventoryArray(inventoryArray);

        inventoryList = ConvertArrayToList(inventoryArray);
        inventoryList.Add("Helmet");
        DisplayInventoryList(inventoryList);

        inventoryList.Remove("Shield");
        
        DisplayInventory(inventoryList);
        DisplayInventory(inventoryArray);
    }

    List<string> ConvertArrayToList(string[] array)
    {
        List<string> tempList = new List<string>();
        for (int i = 0; i < array.Length; i++)
        {
            tempList.Add(array[i]);
        }

        return tempList;
    }
    
    void DisplayInventoryArray(string[] inventory)
    {
        Debug.Log("**Inventory Array: ");
        for (int i = 0; i < inventory.Length; i++)
        {
            Debug.Log($"{i+1}. {inventory[i]}, ");
        }
    }

    void DisplayInventoryList(List<string> list)
    {
        Debug.Log("**Inventory List: ");
        int i = 1;
        foreach (var s in list)
        {
            Debug.Log($"{i}. {s},");
            i++;
        }
    }
    
    //display elements for both array and list
    void DisplayInventory(IEnumerable<string> inventory)
    {
        Debug.Log("***Player Inventory: ");
        int i = 1;
        foreach (var item in inventory)
        {
            Debug.Log($"{i}. {item},");
            i++;
        }
    }
    
}
