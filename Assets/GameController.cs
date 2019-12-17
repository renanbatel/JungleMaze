using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    private int Score;
    private Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        this.LoadValues();
    }

    void LoadValues()
    {
        GameObject score = GameObject.Find("Score");

        this.Score = 0;
        this.ScoreText = score.GetComponent<Text>();
    }

    public void AddScore()
    {
        this.Score += 1;

        this.ScoreText.text = this.Score.ToString();
    }
}
