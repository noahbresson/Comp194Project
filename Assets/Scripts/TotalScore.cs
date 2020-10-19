using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalScore : MonoBehaviour
{
    public GameObject trashBin;
    public GameObject trashBinGreen;
    public GameObject trashBinBlue;
    private int TotalScore;
    public GameObject Text
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
         /*TrashBin.GetComponent<BinDrop>().GetScore();
         TrashBinGreen.GetComponent<BinDrop>().GetScore();
         TrashBinBlue.GetComponent<BinDrop>().GetScore();*/
         TotalScore =  TrashBinBlue.GetComponent<BinDrop>().GetScore() + TrashBinGreen.GetComponent<BinDrop>().GetScore() + TrashBin.GetComponent<BinDrop>().GetScore();

    }
}
