using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public GameObject Player;
    public static int score;
    public Text scoreText;

    void Update ()
    {
        if (Input.GetButtonDown("up"))
        {
            score += 1;
        }

        if (Input.GetButtonDown("down"))
        {
            score -= 3;
        }

        scoreText.text = score.ToString();
    }
}
