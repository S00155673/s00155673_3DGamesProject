using UnityEngine;

public class Movement : MonoBehaviour
{
    //Controls the amount of time the object moves from points x - y...
    private float lerping;

    //Current lerping time...
    private float currentLerp;

    //Precent complete of lerp
    private float percent = 1;

    //These are the Start and end Positions used for movement...
    private Vector3 startPos;

    private Vector3 endPos;

    //This is to check if there has been something inputed...
    private bool startInput;

    //This is for telling the animation that a jump has been initiated...
    public bool justJumped;

    private void Update()
    {
        //transform.rotation = Quaternion.identity;

        //Here its checking to see if the buttons up,down,left,right are being hit...
        if (Input.GetButtonDown("up") ||
            Input.GetButtonDown("down") ||
            Input.GetButtonDown("left") ||
            Input.GetButtonDown("right"))
        {
            //This is for making sure the player has reached their target pos...
            if (percent == 1)
            {
                lerping = 1;
                currentLerp = 0;
                startInput = true;
                justJumped = true;
            }
        }
        //Here the start position is being set as the current transform of the gameobject...
        startPos = gameObject.transform.position;

        //For the End position its more complicated as this can be either + 1 or - 1 on the x and z axies...
        //E.G is player hits up arrow it will be transformed  + 1 on the Z axis...
        if (Input.GetButtonDown("up") && gameObject.transform.position == endPos)
        {
            endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
            //This and the latter mean that when the player moves the gameobject will rotate...
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetButtonDown("down") && gameObject.transform.position == endPos)
        {
            endPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetButtonDown("left") && gameObject.transform.position == endPos)
        {
            endPos = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
            gameObject.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetButtonDown("right") && gameObject.transform.position == endPos)
        {
            endPos = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
            gameObject.transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        if (startInput == true)
        {
            currentLerp += Time.deltaTime * 4f;
            //Current lerping time divided by the lerping time gives the percent...
            percent = currentLerp / lerping;
            gameObject.transform.position = Vector3.Lerp(startPos, endPos, percent);

            //Checking to see if the Animation is close to ending...
            if (percent > 0.8)
            {
                percent = 1;
            }
            //This ensure that there cannot be 2 jumps...
            if (Mathf.Round(percent) == 1)
            {
                justJumped = false;
            }
        }
    }
}