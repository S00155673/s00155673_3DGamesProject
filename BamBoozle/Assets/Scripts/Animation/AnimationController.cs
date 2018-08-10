using UnityEngine;

public class AnimationController : MonoBehaviour
{
    //For referancing the animator on the object...
    private Animator animator;

    //This is the gameobject that holds the movement script...
    public GameObject player;

    private void Start()
    {
        //Getting the animator from the gameobject that has the script attached...
        animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        //Getting the movement script...
        Movement movementScript = player.GetComponent<Movement>();

        //if the variable from script Movement, justJumped is true...
        if (movementScript.justJumped == true)
        {
            //Set the bool that named Jump in the animator to true...
            animator.SetBool("Jump", true);
        }
        else
        {
            //else false...
            animator.SetBool("Jump", false);
        }
    }
}