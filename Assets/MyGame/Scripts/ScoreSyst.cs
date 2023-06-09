using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSyst : MonoBehaviour
{
    public TextMesh scoreText;
    public PickUps script;
    public int maxScore;
    public GameObject score;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void AddScore(int newScore)
    {
        script.scorePickUp += newScore;
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + script.scorePickUp;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore();

        if (script.scorePickUp == maxScore)
        {
            score.SetActive(false);
        }
    }
}