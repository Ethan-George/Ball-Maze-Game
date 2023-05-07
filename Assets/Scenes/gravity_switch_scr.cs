using System.Collections;
using UnityEngine;

public class gravity_switch_scr : MonoBehaviour
{
    public Rigidbody2D rb;
    public float time = 2;

    // when the gravity switcher is collided with then switch the gravity of the ball
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(gravitySwitch());
    }

    // switches the gravity of the ball for time seconds then switch the gravity back to normal
    IEnumerator gravitySwitch()
    {
        rb.gravityScale = -1;
        yield return new WaitForSecondsRealtime(time);
        rb.gravityScale = 1;
    }
}
