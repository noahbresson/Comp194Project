using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinDrop : MonoBehaviour
{
     public AudioClip ding;
     public list<String> trashList;
     public list<String> compostList;
     public list<String> recycleList;
     private int score;
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
        
        int score = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if(gameObject.name == "TrashBin")
        {
            if (trashList.Contains(other.gameObject.name))
            {
                 AudioSource ding = GetComponent<AudioSource>();
                 audio.Play(ding); 
                 score = score + 1; 
            }
        }

        else if(gameObject.name == "TrashBinGreen")
        {
            if (compostList.Contains(other.gameObject.name))
            {
                AudioSource ding = GetComponent<AudioSource>();
                 audio.Play(ding);
                 score = score + 1;
            }
        }
        
        else if (gameObject.name == "TrashBinBlue")
        {
            if(recycleList.Contains(other.gameObject.name))
            {
                 AudioSource ding = GetComponent<AudioSource>();
                 audio.Play(ding);
                 score = score + 1;
            }

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
