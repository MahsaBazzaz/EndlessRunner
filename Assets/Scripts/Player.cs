using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Vector2 Position;
    [SerializeField] private float Delta;
    [SerializeField] private float Speed;
    [SerializeField] private float MaxHeight;
    [SerializeField] private float MinHeight;
    [SerializeField] private int Health;
    [SerializeField] private GameObject Moveeffect;
    [SerializeField] private Animator PlayerAnimator;
    [SerializeField] private Shake CameraShaker;
    [SerializeField] private UIManager UI;
    [SerializeField] private GameObject GameOver;
    [SerializeField] private GameObject JumpSound;
    void Start()
    {
        CameraShaker = Camera.main.GetComponent<Shake>();
        UI.SetMaxHealth(Health);
        UI.SetHealth(Health);
    }

    void Update()
    {
        if (Health <= 0)
        {
            GameOver.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, Position, Speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Instantiate(JumpSound, transform.position, Quaternion.identity);
            CameraShaker.ShakeVertical();
            Instantiate(Moveeffect, transform.position, Quaternion.identity);
            PlayerAnimator.SetTrigger("Taunt");
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
            Instantiate(JumpSound, transform.position, Quaternion.identity);
            CameraShaker.ShakeVertical();
            Instantiate(Moveeffect, transform.position, Quaternion.identity);
            PlayerAnimator.SetTrigger("Taunt");
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
        UI.SetHealth(Health);
    }
}
