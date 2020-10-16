using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinDrop : MonoBehaviour
{
     public list<String> trashList;
     public list<String> compostList;
     public list<String> recycleList;
    // Start is called before the first frame update
    void Start()
    {
        trashList = new list<String>(); 
        trash.Add("ChipBag");
        trash.Add("Wrapper");

        compostList = new list<String>();
        compost.Add("Banana");
        compost.Add("Fork");
        compost.Add("Apple");
        compost.Add("Orange");
        
        recycleList = new list<String>();
        recycle.Add("Paper");
        recycle.Add("Cardboard");
        recycle.Add("Bottle");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
