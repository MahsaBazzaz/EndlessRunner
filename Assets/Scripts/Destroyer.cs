using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private float Lifetime;

    void Start()
    {
        Destroy(gameObject, Lifetime);
    }
}
