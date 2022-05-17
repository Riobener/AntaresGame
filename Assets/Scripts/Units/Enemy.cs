using System;
using UnityEngine;
using Debug = System.Diagnostics.Debug;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    public GameObject player;
    private Rigidbody2D _rigidbody2D;

    private void Move()
    {
        
        GetComponent<Rigidbody2D>().velocity = player.transform.position.normalized * _speed;
    }


    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
        Move();
    }


    private void FixedUpdate() => Attack();

    protected  void Attack()
    {
        if (player.transform.position.y < gameObject.transform.position.y)
        {
            _rigidbody2D.velocity = player.transform.position.normalized * _speed;
        }
    }
}
