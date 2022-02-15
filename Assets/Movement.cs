using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    
    private Rigidbody2D rb;
    
    private float movespeed = 0.0065f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            rb.position = touch.deltaPosition * movespeed + rb.position;
            if(rb.position.x > 2f) rb.position = new Vector2(2f, rb.position.y);
            if(rb.position.x < -2f) rb.position = new Vector2(-2f, rb.position.y);
            if(rb.position.y > 4.75f) rb.position = new Vector2(rb.position.x, 4.75f);
            if(rb.position.y < -4.75f) rb.position = new Vector2(rb.position.x, -4.75f);
            Debug.Log(rb.position);
            
        }
    }
}
