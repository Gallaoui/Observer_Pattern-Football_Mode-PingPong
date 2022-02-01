using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Vector3 init;
    public float BounceSpeed = 1f;
    
    private void Awake()
    {
        int xDir = Random.Range(0, 2) == 0 ? -4 : 4;
        int zDir = Random.Range(0, 2) == 0 ? -4 : 4;
        Debug.Log("XSpeed : " + xDir);
        Debug.Log("ZSpeed : " + zDir);
        init = new Vector3(xDir, 0, zDir);
        GetComponent<Rigidbody>().AddForce(this.init * 5, ForceMode.Impulse);
    }   
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Players"))
        {
            //this.BounceSpeed++;
            Debug.Log("Speed : " + this.BounceSpeed);
        }
    }
}
