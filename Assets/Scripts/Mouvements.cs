using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;


public class Mouvements : MonoBehaviour
{
    private float speed = 3f;
    public Material col;
    public Material colp;
    public Material colv;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && transform.position.x > 700)
        {
            transform.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.Q) && transform.position.x < 1300)
        {
            transform.Translate(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) && transform.position.z < 523)
        {
            transform.Translate(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.Z) && transform.position.z > 87)
        {
            transform.Translate(0, 0, -speed);
        }
    }
}
