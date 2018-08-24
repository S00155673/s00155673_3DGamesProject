﻿using UnityEngine;

public class Detector : MonoBehaviour
{
    public static Vector3 checkpoint;
    private GameObject Player;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
        checkpoint = Player.transform.position;
    }

    private void Update()
    {
        if (transform.position.y < -10f)
        {
            Spawn();
        }
    }

    public void Spawn()
    {
        Score.score -= 10;
        transform.position = checkpoint;
    }
}