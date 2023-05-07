using UnityEngine;

public class camera_scr : MonoBehaviour
{
    public ball_scr ball;

    // every frame move the camera to the correct posistion
    void Update()
    {
        // moves the camera to a posistion depending on the current level
        if (ball.getLevel() == 0)
        {
            transform.position = new Vector3(0, 0, -10);
        }
        else if (ball.getLevel() == 1)
        {
            transform.position = new Vector3(22, 0, -10);
        }
        else if (ball.getLevel() == 2)
        {
            transform.position = new Vector3(46, 0, -10);
        }
        else if (ball.getLevel() == 3)
        {
            transform.position = new Vector3(0, -13.35f, -10);
        }
    }
}
