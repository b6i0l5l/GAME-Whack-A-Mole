using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text scoretext;
    int score;
    //store a value(score) and keep the value(score) increase
    public int Scoretotal
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
            updatescore();
        }
    }

    
    void updatescore () {
        scoretext.text = score.ToString("0");
	}
}
