using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    Vector2 _lookDirection;
    [SerializeField] Transform _firePoint,_okSpawner;
    float _lookAngle;
    bool _attack;
    [SerializeField] GameObject _ok;
    [SerializeField] Rigidbody2D _okRigid;
    public Vector2 _gunPos;
    [SerializeField] float _force;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        //_okRigid.AddForce(_gunPos * _force);
    }
    // Update is called once per frame
    void Update()
    {
        _gunPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Vector2 _rotation = _gunPos - _firePoint.position;

        //float rotationZ = Mathf.Atan2(_rotation.y, _rotation.x) * Mathf.Rad2Deg;

        //_firePoint.rotation = Quaternion.Euler(0, 0, rotationZ);
        _firePoint.position =  new Vector3(_gunPos.x, _gunPos.y);

       
    }

    
}
