using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Current Player
    public GameObject currentPlayer;

    //the Exit position for the camera...
    private Vector3 exitPos;

    private void Update()
    {
        //Lerp (interpolate) between 2 positions...
        exitPos = Vector3.Lerp(gameObject.transform.position, currentPlayer.transform.position, Time.deltaTime);
        gameObject.transform.position = new Vector3(exitPos.x, .5f, exitPos.z);
    }
}