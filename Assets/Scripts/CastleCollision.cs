using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleCollision : MonoBehaviour
{
    [SerializeField] Animator _enemy1Anim, _enemy2Anim;
    [SerializeField] float _maxDistance;
    [SerializeField] LayerMask _kaleLayer;
    [SerializeField] Transform _raycastTrans;
    private void OnCollisionStay2D(Collision2D collision)
    {
        //if (collision.gameObject.CompareTag("Dusman"))
        //{
        //    collision.gameObject.GetComponent<EnemyController>().Enemystop();
        //    collision.gameObject.GetComponent<EnemyController>()._anim.Play("EnemyAttack");
        //}
        //if (collision.gameObject.CompareTag("Dusman1"))
        //{
        //    collision.gameObject.GetComponent<EnemyController>().Enemystop();
        //    collision.gameObject.GetComponent<EnemyController>()._anim.Play("EnemyAttack");
        //}
    }

    public void Raycast()
    {
        RaycastHit2D _hit = Physics2D.Raycast(_raycastTrans.position, _raycastTrans.forward, _maxDistance, _kaleLayer);
        Debug.DrawRay(_raycastTrans.position, _raycastTrans.forward * _maxDistance, Color.red);

        if (_hit.collider.gameObject.tag == "Dusman")
        {
            _hit.collider.gameObject.GetComponent<EnemyController>().Enemystop();
            _hit.collider.gameObject.GetComponent<EnemyController>()._anim.Play("EnemyAttack"); ;
        }

        else
        {
            _hit.collider.gameObject.GetComponent<Enemy2Controller>().Enemystop();
            _hit.collider.gameObject.GetComponent<Enemy2Controller>()._anim.Play("EnemyAttack"); ;
        }
    }

    private void FixedUpdate()
    {
        Raycast();
    }
}
