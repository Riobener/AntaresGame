using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public abstract class Weapon : MonoBehaviour
{
    
    [FormerlySerializedAs("bullet")] [SerializeField] protected BlasterBullet blasterBullet;
    [SerializeField] protected string _label;
    [SerializeField] protected int fireSpeed;
    [SerializeField] protected Sprite _sprite;
    public abstract void Shoot(Transform firePoint);


}
