using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float maxSpeed = 8;
    public float shipHeight = 1.3f;
    public float shipWidth = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //returns a float from -1.0 to 1.0
        Input.GetAxis("Vertical");
        Vector3 pos = transform.position;
        pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        //Input.GetAxis("Vertical");
        transform.position = pos;

        Input.GetAxis("Horizontal");
        pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
        transform.position = pos;

        //Boundaries
        if (pos.y + shipHeight > Camera.main.orthographicSize){// + shipRadius 
            pos.y = Camera.main.orthographicSize - shipHeight;// - shipRadius
        }
        if (pos.y< -Camera.main.orthographicSize){// - shipRadius 
            pos.y = -Camera.main.orthographicSize;//+ shipRadius
        }
        
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float gameWidth = Camera.main.orthographicSize * screenRatio;
        if (pos.x + shipWidth > gameWidth){// + shipRadius 
            pos.x = gameWidth - shipWidth;// - shipRadius
        }
        if (pos.x - shipWidth < -gameWidth){// - shipRadius 
            pos.x = -gameWidth + shipWidth;//+ shipRadius
        }
        transform.position = pos;

        
    }
}
