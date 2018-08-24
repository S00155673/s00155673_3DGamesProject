//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Respawn : MonoBehaviour
//{
//    public GameObject player;

//    // Use this for initialization
//    void Awake()
//    {
//        player = GameObject.FindWithTag("Player");
//    }

//    void OnCollisionEnter(Collision col)
//    {
//        if (col.gameObject.tag == "Player")
//        {
//            player.GetComponent<Detector>().Spawn();
//        }
//    }
//}
