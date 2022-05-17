using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    public int health;

    protected abstract void Move();
    protected abstract void Attack();


}
