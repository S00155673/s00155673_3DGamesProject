using UnityEngine;

public class Respawn : MonoBehaviour
{
    private GameObject player;
    private void Awake()
    {
        player = GameObject.FindWithTag("Player");
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            //Respawn at last checkpoint...
            player.GetComponent<Detector>().Spawn();
        }
    }
}