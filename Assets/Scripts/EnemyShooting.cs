using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shotsDelay = 0.5f;
    public float cooldown = 0;
    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;
        if (cooldown <= 0)
        {
            cooldown = shotsDelay;
            Vector3 offset = new Vector3(0, -0.5f, 0);
            Quaternion offtrans = new Quaternion(0, 0, 0, 0);
            Instantiate(bulletPrefab, transform.position + offset , transform.rotation * offtrans);
        }
    }
}
