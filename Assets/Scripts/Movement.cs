using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{




    private float _lrBoarder;

    private float _udBoarder;
    private Vector2 _startPos;
    private Vector2 _endPos;
    private Vector2 _firstTouchPos;

   
    // Start is called before the first frame update
    void Start()
    {
        var localScale = transform.localScale; 
        Vector3 screenSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        _lrBoarder = screenSize.x - (localScale.x / 2);
        _udBoarder = screenSize.y - (localScale.y / 2);
         
        Application.targetFrameRate = 60;

    }



    private void FixedUpdate()
    {
        Move();
        var position = transform.position;
        position = new Vector3
        (
            Mathf.Clamp(position.x, -_lrBoarder, _lrBoarder),
            Mathf.Clamp(position.y, -_udBoarder, _udBoarder),
            position.z

        );
        transform.position = position;
    }

    void Move()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            transform.Translate(touch.deltaPosition.x * 5 / Screen.width,touch.deltaPosition.y * 10 / Screen.height ,0,Space.World);
        }
    }
}
