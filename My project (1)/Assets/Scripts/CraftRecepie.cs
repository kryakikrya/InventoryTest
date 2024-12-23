using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftRecepie : MonoBehaviour
{
    public Item[,] Items {  get; private set; }
    
    public int Amount { get; private set; }

    public Item[] ItemsOrder { get; private set; }

    public CraftRecepie(Item[,] items, int amount)
    {
        Items = items;
        Amount = amount;
        ItemsOrder = new Item[Items.Length];

        for (int orderId = 0, i = 0; i < Items.GetLength(0); i++)
        {
            for (int k = 0; k < Items.GetLength(1); k++)
            {
                ItemsOrder[orderId++] = Items[i, k];
            }
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
