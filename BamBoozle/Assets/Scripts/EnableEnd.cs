using UnityEngine;

public class EnableEnd : MonoBehaviour
{
    public GameObject EndPanel;
    public GameObject TopPanel;

    private void Start()
    {
        //Set to not appear...
        EndPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider collider)
    {
        //When Player Collides with "End" show and disable panels...
        if (collider.gameObject.tag == "Player")
        {
            EndPanel.SetActive(true);
            TopPanel.SetActive(false);
        }
    }
}