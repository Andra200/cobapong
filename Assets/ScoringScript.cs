using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoringScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoringtextP1, scoringtextP2;
    public static int scoreP1=0, scoreP2=0;
    void Start()
    {
        scoringtextP1.text = scoreP1.ToString();
        scoringtextP1.text = scoreP2.ToString();
    }

    public void UpdateScore(string namaWall){
        if(namaWall=="DindingKiri"){
            scoreP2 += 1;
            scoringtextP2.text = scoreP2.ToString();
        }else if(namaWall=="DindingKanan"){
            scoreP1 += 1;
            scoringtextP1.text = scoreP1.ToString();
        }
    }
}
