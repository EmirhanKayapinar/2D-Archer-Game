using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] GameObject OkSpawner;
    [SerializeField] GameObject Ok;
    [SerializeField] Rigidbody2D _okRigid;
    [SerializeField] float _okSpeed;
    bool _isAttack;
    [SerializeField] Animator _anim;
    float _mana = 2;
    public void OkSpawn()
    {
        StartCoroutine(Attack());
        
    }

    IEnumerator Attack()
    {
        switch (_isAttack&& _mana>1.7)
        {
            case true:
                _isAttack = false;
                _mana = 0;
                _anim.SetBool("__isAttack", true);
                yield return new WaitForSeconds(1.57f);
                Instantiate(Ok, OkSpawner.transform.position, OkSpawner.transform.rotation);
                OkSpeed();
                _anim.SetBool("__isAttack", false);

                

                break;
        }
        _isAttack = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        _isAttack = false;
        _mana += Time.deltaTime;
        
    }

    void OkSpeed()
    {
        _okRigid.AddForce(Vector2.right*_okSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        switch (Input.GetMouseButtonDown(0))
        {
            case true:
                _isAttack = true;
                break;
        }
    }
}
