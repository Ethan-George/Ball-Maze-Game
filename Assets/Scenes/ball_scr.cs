using UnityEngine;

public class ball_scr : MonoBehaviour
{
    public Rigidbody2D rb;
    private int level = 0;
    
    // every frame the controls method is called
    void Update()
    {
        controls();
    }

    // moves the ball if A, D, LeftArrow, or RightArrow is pressed and resets the level if R is pressed
    private void controls()
    {
        // moves the ball left if A or LeftArrow is pressed
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(200 * -new Vector2(1, 0) * Time.deltaTime);
        }

        // moves the ball right if D or RightArrow is pressed
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(200 * new Vector2(1, 0) * Time.deltaTime);
        }

        // resets the level if R is pressed
        if (Input.GetKey(KeyCode.R))
        {
            reset();
        }
    }

    // resets the current level
    private void reset()
    {
        // sets the ball's velocity to zero
        rb.velocity = new Vector2(0, 0);

        // moves the ball to a posistion depending on the current level
        if (level == 0)
        {
            rb.transform.position = new Vector2(0, 4.3f);
        }
        else if (level == 1)
        {
            rb.transform.position = new Vector2(30, 4.25f);
        }
        else if (level == 2)
        {
            rb.transform.position = new Vector2(38, -4.4f);
        }
        else if (level == 3)
        {
            rb.transform.position = new Vector2(-8, -17);
        }
    }

    // returns the current level
    public int getLevel()
    {
        return level;
    }

    // adds a level and resets to that level
    public void addLevel()
    {
        level++;
        reset();
    }
}
