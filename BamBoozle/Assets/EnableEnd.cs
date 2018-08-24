using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEnd : MonoBehaviour
{

    public GameObject EndPanel;
    public GameObject TopPanel;

    //public EventSystem System;

    // Use this for initialization
    void Start ()
    {
        EndPanel.SetActive(false);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            EndPanel.SetActive(true);
            TopPanel.SetActive(false);
        }
    }
}
