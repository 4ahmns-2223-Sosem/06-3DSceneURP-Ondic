using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour

{
    public GameObject scoretext;

    private void Start()
    {
        scoretext.GetComponent<Text>().text = "0";
    }

    public void setscore(float scoretoadd)
    {
        float currentscore = float.Parse(scoretext.GetComponent<Text>().text);
        float newscore = currentscore + scoretoadd;
        scoretext.GetComponent<Text>().text = newscore.ToString("F0");
    }
}