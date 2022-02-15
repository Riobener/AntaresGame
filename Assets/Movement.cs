using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
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
        }
    }
}
