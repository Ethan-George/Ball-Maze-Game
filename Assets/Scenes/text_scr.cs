using UnityEngine;

public class text_scr : MonoBehaviour
{
    public ball_scr ball;
    public Canvas textCanvas;
    public int textLevel;

    // every frame checks if the text should be shown
    void Update()
    {
        // if the current level is the level that the text is to be shown on then turn the canvas on
        if (ball.getLevel() == textLevel)
        {
            textCanvas.enabled = true;
        }

        // else turn the canvas off
        else
        {
            textCanvas.enabled = false;
        }
    }
}
