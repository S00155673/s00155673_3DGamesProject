using UnityEngine;

public class UpdateCheckpoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            //Update the checkpoint to be the checkpoints objects position...
            Detector.checkpoint = transform.position;
        }
    }
}