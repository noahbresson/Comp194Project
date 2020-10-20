using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TotalScore : MonoBehaviour
{
    public GameObject trashBin;
    public GameObject trashBinGreen;
    public GameObject trashBinBlue;
    private int FinalScore;
    public TMP_Text ScoreBoard;
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
         FinalScore =  trashBinBlue.GetComponent<BinDrop>().GetScore() + trashBinGreen.GetComponent<BinDrop>().GetScore() + trashBin.GetComponent<BinDrop>().GetScore();
         ScoreBoard.text = "Total score:  "
    }
}
