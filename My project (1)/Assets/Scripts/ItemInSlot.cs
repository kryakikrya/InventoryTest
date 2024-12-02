using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInSlot : MonoBehaviour
{
    public Item Item {  get; private set; }

    public int Amount {  get;  set; }

    public ItemInSlot(Item item, int amount)
    {
        Item = item;
        Amount = amount;
    }
}
