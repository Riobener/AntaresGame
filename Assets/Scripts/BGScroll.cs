using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{

    public float scrollSpeed;
    public float tileSize = 17;
    private Transform curentObject;
    // Start is called before the first frame update
    void Start()
    {
        curentObject = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        curentObject.position = new Vector3(curentObject.position.x, -Mathf.Repeat(Time.time * scrollSpeed, tileSize),
            curentObject.position.z);
            
    }
}
