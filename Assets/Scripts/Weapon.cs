using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int fireSpeed = 10; 
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Time.frameCount % fireSpeed == 0)
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        
    }
}
