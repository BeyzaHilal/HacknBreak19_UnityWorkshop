using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{

    public static SoundController instance = null;
    
    public AudioSource CollisionSound;
    public AudioSource FireSound;
    public AudioSource ExplosionSound;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if( instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void PlayCollisionSound()
    {
        CollisionSound.Play();
    }

    public void PlayFireSound()
    {
        FireSound.Play();
    }

    public void PlayExplosionSound()
    {
        ExplosionSound.Play();
    }
}
