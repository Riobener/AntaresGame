using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserGun : Weapon
{
    
    public override void Shoot(Transform firePoint)
    {
        if (Time.frameCount % fireSpeed == 0)
        {
            Instantiate(bullet, firePoint.position, Quaternion.identity);
        }
    }
}
