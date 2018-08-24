using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public static Vector3 checkpoint;
    private GameObject Player;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
        checkpoint = Player.transform.position;
    }

    public void Spawn()
    {
        Score.score -= 10;
        transform.position = checkpoint;
    }
}
