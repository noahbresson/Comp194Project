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
        trashList = new List<String>(); 
        trash.Add("ChipBag");
        trash.Add("Wrapper");

        compostList = new List<String>();
        compost.Add("Banana");
        compost.Add("Fork");
        compost.Add("Apple");
        compost.Add("Orange");
        
        recycleList = new List<String>();
        recycle.Add("Paper");
        recycle.Add("Cardboard");
        recycle.Add("Bottle");
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(gameObject.name == "TrashBin")
        {
            if (trashList.Contains(other.gameObject.name))
            {
                
            }
        }

        else if(gameObject.name == "TrashBinGreen")
        {
            if (compostList.Contains(other.gameObject.name))
            {

            }
        }
        
        else if (gameObject.name == "TrashBinBlue")
        {
            if(recycleList.Contains(other.gameObject.name))
            {

            }

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
