using System.Collections.Generic;
using UnityEngine;


public class Player : Unit
{
    [SerializeField]private Transform _firePoint;
    [SerializeField] private List<Weapon> _weapons;
    [SerializeField]private Weapon _currentWeapon;
    private float _lrBoarder;
    private float _udBoarder;
    [SerializeField]private const float FireRate = 0.001f;
    private float _nextFire = 0.0f;
    
    private void Start()
    {
      
        _currentWeapon = _weapons[0];
        var localScale = transform.localScale; 
        Vector3 screenSize = Camera.main!.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        _lrBoarder = screenSize.x - (localScale.x * 5);
        _udBoarder = screenSize.y - (localScale.y * 5);
        Application.targetFrameRate = 60;
    }
    
    
    private void Update()
    {
        if (Input.touchCount > 0 && Time.time > _nextFire)
        {
            _nextFire = Time.time + FireRate;
            Attack();
        }
    }

    private void FixedUpdate()
    {
        Move();
        
    }


    private void CheckBorders(Vector3 position)
    {
        transform.position = new Vector3
        (
            Mathf.Clamp(position.x, -_lrBoarder, _lrBoarder),
            Mathf.Clamp(position.y, -_udBoarder, _udBoarder),
            position.z

        );
    }

    protected override void Move()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            transform.Translate(touch.deltaPosition.x * 5 / Screen.width,touch.deltaPosition.y * 10 / Screen.height ,0,Space.World);
            CheckBorders(transform.position);
        }
    }

    protected override void Attack()
    {
        _currentWeapon.Shoot(_firePoint);
    }
}
