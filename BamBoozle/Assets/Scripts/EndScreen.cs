using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{

    bool gameStopped = false;
    public Text FinalScore;

    // Update is called once per frame
    void Update()
    {
        FinalScore.text = Score.score.ToString();

        if (gameStopped == true)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("MainMenu");
                
            }
        }
    }

    void OnTriggerEnter(Collider collider)
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
