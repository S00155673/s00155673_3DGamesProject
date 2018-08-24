using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
	void Update ()
    {
        if (Input.GetButtonDown("up"))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
            //This and the latter mean that when the player moves the gameobject will rotate...
            gameObject.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetButtonDown("down"))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
            gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetButtonDown("left"))
        {
            gameObject.transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
            gameObject.transform.rotation = Quaternion.Euler(0, -180, 0);
        }
        if (Input.GetButtonDown("right"))
        {
            gameObject.transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
