using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : MonoBehaviour
{


    [SerializeField] Rigidbody2D _rigid;
    [SerializeField] float _upSpeed,_leftSpeed;
    [SerializeField] GameObject _baloncuk;
    public Animator _anim;
    [SerializeField] Collider2D _col;
    [SerializeField] float _maxDistance;
    [SerializeField] LayerMask _kaleLayer;
    [SerializeField] Transform _raycastTrans;
    GameObject _healthControl;
    public bool _ok;
    bool _diken, _zemin;
    void EnemyMoveUp()
    {
        _rigid.velocity = Vector2.up * _upSpeed * Time.deltaTime;
    }
    void EnemyMoveLeft()
    {
        _rigid.velocity = Vector2.left * _leftSpeed * Time.deltaTime;
    }

    public void Enemystop()
    {
        _rigid.velocity = Vector2.left * 0;
        _rigid.constraints = RigidbodyConstraints2D.FreezeAll;
    }
    private void FixedUpdate()
    {
        if (_diken == false)
        {
            EnemyMoveUp();
        }
        if (_zemin)
        {
            EnemyMoveLeft();
        }
        Raycast();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Diken"))
        {
            _diken = true;
            _rigid.bodyType = RigidbodyType2D.Dynamic;
            _rigid.gravityScale = 1;
            _col.isTrigger = false;
            Destroy(_baloncuk);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            _zemin = true;
            _rigid.bodyType = RigidbodyType2D.Kinematic;
            _anim.Play("Enemy2Run");
        }

        
    }
    public void Raycast()
    {
        RaycastHit2D _hit = Physics2D.Raycast(_raycastTrans.position, _raycastTrans.forward, _maxDistance, _kaleLayer);
        Debug.DrawRay(_raycastTrans.position, _raycastTrans.forward * _maxDistance, Color.red);

        if (_hit.collider!= null && _ok == false)
        {
            Enemystop();
            _anim.Play("Enemy2Attack");
            
        }
   
    }
    public void Destroy()
    {
        Destroy(this.gameObject);
    }
    public void Attack()
    {
        _healthControl.GetComponent<HealthController>().Health2();
    }
    private void Start()
    {
        _healthControl = GameObject.FindGameObjectWithTag("Health");
    }
}
