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
    
    

    // Start is called before the first frame update
    void Start()
    {
        
        
        
        Debug.Log("Initial Inventory: ");
        DisplayInventory(inventoryArray);

        inventoryList = ConvertArrayToList(inventoryArray);
        inventoryList.Add("Helmet");
        DisplayList(inventoryList);
    }

    void DisplayInventory(string[] inventory)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            Debug.Log($"{inventory[i]}, ");
        }
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

    void DisplayList(List<string> list)
    {
        Debug.Log("Inventory List: ");
        foreach (var s in list)
        {
            Debug.Log($"{s},");
        }
    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
