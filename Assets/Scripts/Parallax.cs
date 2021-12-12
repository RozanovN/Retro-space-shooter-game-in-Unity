using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float maxSpeed = 5f;
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (pos.y > 0)
        {
        pos.y -= maxSpeed * Time.deltaTime;
        //Input.GetAxis("Vertical");
        transform.position = pos;
        }
    }
}
