using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    
    private Rigidbody2D rb;
    private float lrBoarder;
    private float udBoarder;
    private float movespeed = 0.0065f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 screenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        lrBoarder = screenSize.x - (transform.localScale.x / 2);
        udBoarder = screenSize.y - (transform.localScale.y / 2);
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            rb.position = touch.deltaPosition * movespeed + rb.position;
            if (rb.position.x > lrBoarder) rb.position = new Vector2(lrBoarder, rb.position.y);
            if (rb.position.x < -lrBoarder) rb.position = new Vector2(-lrBoarder, rb.position.y);
            if (rb.position.y > udBoarder) rb.position = new Vector2(rb.position.x, udBoarder);
            if(rb.position.y < -udBoarder) rb.position = new Vector2(rb.position.x, -udBoarder);

        }
    }
}
