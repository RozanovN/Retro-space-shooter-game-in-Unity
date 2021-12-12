using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float maxSpeed = 5f;
    public float beamHeight = 0.5f;
    public float beamWidth = 0.5f;
    public int rotationSpeed = 25;
    // Update is called once per frame
    void Update()
    {
        //returns a float from -1.0 to 1.0
        Vector3 pos = transform.position;
        pos.y += maxSpeed * Time.deltaTime;
        //Input.GetAxis("Vertical");
        transform.position = pos;
        transform.Rotate(rotationSpeed, 0, 0);

        //pos.x += maxSpeed * Time.deltaTime;
        //transform.position = pos;

        //Boundaries
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float gameWidth = Camera.main.orthographicSize * screenRatio;
        if (pos.y + beamHeight > Camera.main.orthographicSize){// + shipRadius 
            Destroy(gameObject);// - shipRadius
        }
        if (pos.y< -Camera.main.orthographicSize){// - shipRadius 
            Destroy(gameObject);//+ shipRadius
        }
        if (pos.x + beamWidth > gameWidth){// + shipRadius 
            Destroy(gameObject);// - shipRadius
        }
        if (pos.x - beamWidth < -gameWidth){// - shipRadius 
            Destroy(gameObject);//+ shipRadius
        }
        
    }
}
