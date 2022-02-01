using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vers : MonoBehaviour
{
    public GameObject play;
    public Material col;
    public Material colp;
    public Material colv;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, 0, play.transform.position.z);
    }
}
