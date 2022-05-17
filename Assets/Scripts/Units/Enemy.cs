using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = System.Diagnostics.Debug;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    public GameObject player;
    private Rigidbody2D _rigidbody2D;
    private Rigidbody2D _rigidbody2D1;

    private void Move()
    {
        
        GetComponent<Rigidbody2D>().velocity = player.transform.position.normalized * _speed;
    }


    private void Start()
    {
        player = GameObject.FindWithTag("Player");
        _rigidbody2D1 = player.GetComponent<Rigidbody2D>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        
        Move();
    }

    private void Update()
    {
        if (_rigidbody2D.position.y < -6 || _rigidbody2D.position.x < -2.5f || _rigidbody2D.position.x > 2.5f)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate() => Attack();

    protected  void Attack()
    { 
        
        if (player.transform.position.y + 0.1  <= gameObject.transform.position.y)
        {
            _rigidbody2D.velocity = (_rigidbody2D1.position - _rigidbody2D.position).normalized * _speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {

      Destroy(gameObject);
      Destroy(col.gameObject);
      UnityEngine.Debug.LogError(SceneManager.sceneCount - 1);
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        
    }
}
