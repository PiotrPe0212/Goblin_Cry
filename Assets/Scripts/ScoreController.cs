using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public static ScoreController Instance;
    public int Score;
    private void Awake()
    {
        Instance = this;
    }
    

    void Start()
    {
        Score = 0;
        TextChange();
    }

    public void ScoreChange()
    {
        Score += 10;
        TextChange();
    }

    private void TextChange()
    {
        this.GetComponent<Text>().text = Score.ToString();

    }
}
