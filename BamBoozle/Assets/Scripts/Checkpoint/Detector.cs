using UnityEngine;

public class Detector : MonoBehaviour
{
    public static Vector3 checkpoint;
    private GameObject Player;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
        //Setting the checkpoint at start to avoid null...
        checkpoint = Player.transform.position;
    }

    private void Update()
    {
        if (transform.position.y < -10f)
        {
            //If player falls for -10f , fire spawn method...
            Spawn();
        }
    }

    public void Spawn()
    {
        //Death causes a penalty of -10 to score...
        Score.score -= 10;
        //Go to checkpoint...
        transform.position = checkpoint;
    }
}