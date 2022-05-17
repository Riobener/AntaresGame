using System;
using UnityEngine;

public class Blaster : Weapon
{
    [SerializeField] protected AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponentInParent<AudioSource>();
    }

    public override void Shoot(Transform firePoint)
    {
        if (Time.frameCount % fireSpeed == 0)
        {
            Instantiate(bullet, firePoint.position, Quaternion.identity);
            PlaySoundOfShot();
        }

        
    }
    
    private void PlaySoundOfShot()
    {
        audioSource.Play();
        audioSource.PlayOneShot(audioSource.clip);
        // audioSource.PlayOneShot(soundOfShot);
    }
}
