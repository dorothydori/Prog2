using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject ScoreText;
    public GameObject Score;
    public Text textScore;
    public float score;

    // Update is called once per frame
    void Update()
    {
       if(GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1;
            textScore.text = ((int)score).ToString();
        }
    }
}
