using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public GameObject ExplosionEffect;
    

    void OnCollisionEnter2D()
    {
        GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
        Destroy(ExplosionEffectIns, 10);
        Destroy(gameObject, 0);
        
    }
}
