using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dusman"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dusman"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
