using UnityEngine;

public class BrickBehavior : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the object that hit this brick has the "Ball" tag
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Destroy this brick (the GameObject this script is attached to)
            Destroy(gameObject);
        }
    }
}