using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 1;
    public GameObject gameOver;
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Col");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trig");
        health--;
        if (health <= 0) 
        {
            Die();
            gameOver.SetActive(true);
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
