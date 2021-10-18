using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float EndX;
    [SerializeField] private float StartX;

    void Update()
    {
        transform.Translate(Vector3.left * Speed * Time.deltaTime);
        if (transform.position.x <= EndX)
        {
            Vector3 pos = new Vector3(StartX, transform.position.y, 1);
            transform.position = pos;
        }
    }
}
