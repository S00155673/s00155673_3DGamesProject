using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject Player;
    public static int score;
    public Text scoreText;

    private void Update()
    {
        //If pressed score +1 , this is abusable by spamming...
        if (Input.GetButtonDown("up"))
        {
            score += 1;
        }

        //The pentaly for moving backwards...
        if (Input.GetButtonDown("down"))
        {
            score -= 3;
        }

        scoreText.text = score.ToString();
    }
}