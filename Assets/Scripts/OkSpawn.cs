using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkSpawn : MonoBehaviour
{
    bool _isAttack;
    [SerializeField] GameObject _ok;
    [SerializeField] Transform _okSpawner;
    [SerializeField] Rigidbody2D _okrigid;
    [SerializeField] Animator _anim;
    [SerializeField] Transform _raycastTrans;
    
    float _mana;
    public void OkSpawner()
    {
        StartCoroutine(AsyncControl());
        
    }
    
    public void Ok()
    {
        Instantiate(_ok, _okSpawner.transform.position, _okSpawner.transform.rotation);
    }
    IEnumerator AsyncControl()
    { 
        switch (_isAttack && _mana>1.7)
        {
            case true:
                _isAttack = false;
                _mana = 0;
                _anim.SetBool("__isAttack", true); 
                
                yield return new WaitForSeconds(1.57f);
                
                //Instantiate(_ok, _okSpawner.transform.position, _okSpawner.transform.rotation);
                
                _anim.SetBool("__isAttack", false);

                break;
        }
         _isAttack = false;
    
    }
    
    

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _isAttack = true;
        }
    }

    private void FixedUpdate()
    {
        OkSpawner();
        
        _mana += Time.deltaTime;
    }
}
