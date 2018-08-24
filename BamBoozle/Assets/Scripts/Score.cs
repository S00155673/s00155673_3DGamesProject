using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public GameObject Player;
    public static int score;
    public Text scoreText;
    public bool moved;

    // Use this for initialization

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetButtonDown("up"))
        {
            score += 1;
            Debug.Log("poo");
        }

        if (Input.GetButtonDown("down"))
        {
            score -= 2;
        }

        scoreText.text = score.ToString();
    }
}
