using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    public static ItemsManager Instance;

    public List<Item> Items;

    public Sprite[] ItemSprites;

    private void Awake()
    {
        if(!Instance)
            Instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        GenerateItems();
    }

    private void GenerateItems()
    {
        Items = new List<Item>();

        Items.Add(new Item("Leather", ItemSprites[5]));
        var leatherArmorRecepie = new Item[,]
        {
            {Items[0], null, Items[0]},
            {Items[0], Items[0], Items[0]},
            {Items[0], Items[0], Items[0]},
        };
        Items.Add(new Item("Leather Armor", ItemSprites[1], new CraftRecepie(leatherArmorRecepie, 1)));
        var leatherBootsRecepie = new Item[,]
{
            { Items[0], null, Items[0]},
            { Items[0], null, Items[0]},
};
        Items.Add(new Item("Leather Boots", ItemSprites[2], new CraftRecepie(leatherBootsRecepie, 1)));
        var leatherHelmetRecepie = new Item[,]
{
            { Items[0], Items[0], Items[0]},
            { Items[0], null , Items[0]}
};
        Items.Add(new Item("Leather Helmet", ItemSprites[3], new CraftRecepie(leatherHelmetRecepie, 1)));
        var leatherBagRecepie = new Item[,]
{
            {Items[0], null, Items[0]},
            {Items[0], Items[0], Items[0]},
            {Items[0], null, Items[0]},
};
        Items.Add(new Item("Leather Helmet", ItemSprites[0], new CraftRecepie(leatherBagRecepie, 1)));
    }
}
