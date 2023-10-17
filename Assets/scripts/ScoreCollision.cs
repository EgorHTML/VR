using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCollision : MonoBehaviour
{
    private int score;
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        GameObject.Find("Score").GetComponent<TextMeshProUGUI>().text = score.ToString();
    }

    public void IncScore()
    {
        score++;
    }
}
