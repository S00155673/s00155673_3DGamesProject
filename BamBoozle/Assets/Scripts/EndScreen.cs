using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{
    private bool gameStopped = false;
    public Text FinalScore;

    private void Update()
    {
        //Setting final score to show the score...
        FinalScore.text = Score.score.ToString();

        if (gameStopped == true)
        {
            //If user presses K go to main menu...
            if (Input.GetKeyDown(KeyCode.K))
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("MainMenu");
            }
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if (gameStopped == false)
            {
                gameStopped = true;
                Time.timeScale = 0f;
                Debug.Log("Stopped");
            }
            else if (gameStopped == true)
            {
                gameStopped = false;
                Time.timeScale = 1f;
                Debug.Log("Play");
            }
        }
    }
}