using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private Vector2 Position;
    [SerializeField] private float Delta;
    [SerializeField] private float Speed;
    [SerializeField] private float MaxHeight;
    [SerializeField] private float MinHeight;
    [SerializeField] private int Health;
    [SerializeField] private GameObject Moveeffect;
    [SerializeField] private Shake CameraShaker;
    void Start()
    {
        CameraShaker = Camera.main.GetComponent<Shake>();
    }

    void Update()
    {
        if (Health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        transform.position = Vector2.MoveTowards(transform.position, Position, Speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CameraShaker.ShakeVertical();
            Instantiate(Moveeffect, transform.position, Quaternion.identity);
            if (transform.position.y + Delta <= MaxHeight)
            {
                Position = new Vector2(transform.position.x, transform.position.y + Delta);
            }
            else
            {
                Position = new Vector2(transform.position.x, MaxHeight);
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CameraShaker.ShakeVertical();
            Instantiate(Moveeffect, transform.position, Quaternion.identity);
            if (transform.position.y - Delta >= MinHeight)
            {
                Position = new Vector2(transform.position.x, transform.position.y - Delta);
            }
            else
            {
                Position = new Vector2(transform.position.x, MinHeight);
            }
        }
    }
    public void GetDamage(int damage)
    {
        Health -= damage;
    }
}
