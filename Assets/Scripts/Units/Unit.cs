using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    protected int _health;

    protected abstract void Move();
    protected abstract void Attack();


}
