using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    int score = 1;
    void Start()
    {
       
    }
    void Update()
    {
        //score = Score.getscore();
        scoreText.text = string.Format("Score:{0}",score);
    }
}
