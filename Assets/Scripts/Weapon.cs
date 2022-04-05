using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    
    [SerializeField] protected Bullet bullet;
    [SerializeField] private string _label;
    [SerializeField] protected int fireSpeed;
    [SerializeField] private Sprite _sprite;
    public abstract void Shoot(Transform firePoint);


}
