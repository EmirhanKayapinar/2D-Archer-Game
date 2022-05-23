using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rigid;
    [SerializeField] GameObject _baloncuk;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.CompareTag("Diken"))
            {
                _rigid.bodyType = RigidbodyType2D.Dynamic;
                _rigid.gravityScale = 1;
                Destroy(_baloncuk);
            }

        if (collision.gameObject.CompareTag("Ok"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ok"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }

}
