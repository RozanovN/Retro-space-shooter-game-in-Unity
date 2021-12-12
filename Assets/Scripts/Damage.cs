using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int health = 1;

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
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
