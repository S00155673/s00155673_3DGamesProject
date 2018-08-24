using UnityEngine;

public class AttatchPlayer : MonoBehaviour
{
    public GameObject Player;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //The Players transform is set the the parents...
            //This caused issues when the scales were different...
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