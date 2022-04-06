using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaster : Weapon
{
    
    public override void Shoot(Transform firePoint)
    {
        if (Time.frameCount % fireSpeed == 0)
        {
            Instantiate(blasterBullet, firePoint.position, Quaternion.identity);
        }
    }
}
