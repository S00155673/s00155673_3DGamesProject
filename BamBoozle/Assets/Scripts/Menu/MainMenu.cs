using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        //Go to Level 1...
        SceneManager.LoadScene("Level1");
    }

    public void Quit()
    {
        //Quit :)...
        Application.Quit();
    }
}