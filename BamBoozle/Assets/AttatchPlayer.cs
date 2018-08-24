using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttatchPlayer : MonoBehaviour {

    public GameObject Player;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Player.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Player.transform.parent = null;
        }
    }
}
