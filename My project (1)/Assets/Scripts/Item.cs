using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string Name {  get; private set; }

    public Sprite Sprite { get; private set; }

    public CraftRecepie Recepie { get; private set; }

    public bool HasRecepie => Recepie != null;

    public Item(string name, Sprite sprite, CraftRecepie recepie = null)
    {
        Name = name;
        Sprite = sprite;
        Recepie = recepie;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
