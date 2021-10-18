using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private int Damage;
    [SerializeField] private float Speed;
    [SerializeField] private GameObject ExplodeEffect;
    [SerializeField] private Shake CameraShaker;
    [SerializeField] private GameObject ExplosionSound;
    void Start()
    {
        CameraShaker = Camera.main.GetComponent<Shake>();
    }
    void Update()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(ExplosionSound, transform.position, Quaternion.identity);
            CameraShaker.ShakeHorizontal();
            Instantiate(ExplodeEffect, transform.position, Quaternion.identity);
            other.GetComponent<Player>().GetDamage(Damage);
            Destroy(gameObject);
        }
    }

}
