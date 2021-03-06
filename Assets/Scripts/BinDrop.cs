﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinDrop : MonoBehaviour
{
     //public AudioClip ding;
     public List<string> trashList;
     public List<string> compostList;
     public List<string> recycleList;
     private int score;
    // Start is called before the first frame update
    void Start()
    {
       trashList = new List<string>(); 
        trashList.Add("ChipBag");
        trashList.Add("Bar");
        

        compostList = new List<string>();
        compostList.Add("Banana");
        compostList.Add("Fork");
        compostList.Add("Orange");
        
        recycleList = new List<string>();
        recycleList.Add("Paper");
        recycleList.Add("CardboardBox1");
        recycleList.Add("Bottle");
        recycleList.Add ("Line001");
        
        score = 0;
    }

    void OnTriggerEnter(Collider other)
    { //score += 1;
        if(transform.parent.name == "TrashBin")
        {
            if (trashList.Contains(other.gameObject.name))
            {
                 //AudioSource ding = GetComponent<AudioSource>();
                 GetComponent<AudioSource>().Play(0); 
                 score = score + 1; 
                 
            }
        }

        else if(transform.parent.name == "TrashBinGreen")
        {
            if (compostList.Contains(other.gameObject.name))
            {
                 //AudioSource ding = GetComponent<AudioSource>();
                 GetComponent<AudioSource>().Play(0);
                 score = score + 1;

            }
        }
        
        else if (transform.parent.name == "TrashBinBlue")
        {
            if(recycleList.Contains(other.gameObject.name))
            {
                 //AudioSource ding = GetComponent<AudioSource>();
                 GetComponent<AudioSource>().Play(0);
                 score = score + 1;

            }

        }


    }
     public int GetScore()
        {
          return score;
        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
