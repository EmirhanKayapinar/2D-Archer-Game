using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkHiz : MonoBehaviour
{
    private Camera mainCam;
    private Rigidbody2D _rb;
    Vector3 _mousePos,_direction,_rotation;
    public float force;

    private void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

        _rb = GetComponent<Rigidbody2D>();

        _mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        _direction = _mousePos - transform.position;
        _rotation = transform.position - _mousePos;
        _rb.velocity = new Vector2(_direction.x, _direction.y).normalized * force;
        float rot = Mathf.Atan2(_rotation.y, _rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot );

    }
}
