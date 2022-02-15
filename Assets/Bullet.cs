using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        
        rb.velocity = transform.up * speed;
    }

    private void Update()
    {
        
        if (rb.position.y > camera.orthographicSize + 1)
        {
            
            Destroy(gameObject);
        }
    }


}
