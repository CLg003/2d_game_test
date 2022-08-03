using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    public GameObject ExplosionEffect;
    public SpriteRenderer visible;
    public Transform player;
    public bool destroyed = false;

    void OnCollisionEnter2D()
    {
        GameObject ExplosionEffectIns = Instantiate(ExplosionEffect, transform.position, Quaternion.identity);
        Destroy(ExplosionEffectIns, 10);
        visible.enabled = false;
        destroyed = true;

    }
}
