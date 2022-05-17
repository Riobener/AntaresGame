using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    [SerializeField] private float _speed = 10f;
    [SerializeField] private int _damage;
    
    private void FixedUpdate() 
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime,Space.World ); 
    }


}
