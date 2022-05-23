using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkCollision : MonoBehaviour
{
    [SerializeField] float _maxDistance;
    [SerializeField] LayerMask _kaleLayer;
    [SerializeField] Transform _raycastTrans;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dusman"))
        {
            Destroy(gameObject);
            //Destroy(collision.gameObject);
            collision.gameObject.GetComponent<EnemyController>()._anim.Play("EnemyDead");
            collision.gameObject.GetComponent<EnemyController>().Enemystop();
        }
        if (collision.gameObject.CompareTag("Dusman1"))
        {
            Destroy(gameObject);
            //Destroy(collision.gameObject);
            collision.gameObject.GetComponent<Enemy2Controller>()._anim.Play("Enemy2Dead");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Dusman"))
        {
            Destroy(gameObject);
            //Destroy(collision.gameObject);
            collision.gameObject.GetComponent<EnemyController>().Enemystop();
            collision.gameObject.GetComponent<EnemyController>()._anim.Play("EnemyDead");
            collision.gameObject.GetComponent<EnemyController>()._ok = true;
        }
        if (collision.gameObject.CompareTag("Dusman1"))
        {
            Destroy(gameObject);
            //Destroy(collision.gameObject);
            collision.gameObject.GetComponent<Enemy2Controller>().Enemystop();
            collision.gameObject.GetComponent<Enemy2Controller>()._anim.Play("Enemy2Dead");
            collision.gameObject.GetComponent<Enemy2Controller>()._ok = true;
        }
    }


    //public void Raycast()
    //{
    //    RaycastHit2D _hit = Physics2D.Raycast(_raycastTrans.position, _raycastTrans.forward, _maxDistance, _kaleLayer);
    //    Debug.DrawRay(_raycastTrans.position, _raycastTrans.forward * _maxDistance, Color.red);
    //    if (_hit.collider != null)
    //    {


    //            Debug.Log("Carpti");

    //    }


    //}

    //private void FixedUpdate()
    //{
    //    Raycast();
    //}
}
