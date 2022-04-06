using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterBullet : MonoBehaviour
{
    
    [SerializeField] private float _speed = 10f;
    [SerializeField] private int _damage;
    
    private void FixedUpdate() 
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime,Space.World ); 
    }


}
