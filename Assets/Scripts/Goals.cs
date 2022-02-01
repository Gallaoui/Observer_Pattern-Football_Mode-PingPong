using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goals : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.Translate(0, 0, 0);
            StartCoroutine(CountStart(other));
        }
    }
    IEnumerator CountStart(Collider obj)
    {
        yield return new WaitForSeconds(1);
        obj.gameObject.transform.position = new Vector3(700f, 18, 300);
        yield return new WaitForSeconds(1);
        int xDir = Random.Range(0, 2) == 0 ? -4 : 4;
        int zDir = Random.Range(0, 2) == 0 ? -4 : 4;
        obj.gameObject.GetComponent<Rigidbody>().AddForce(xDir,0,zDir, ForceMode.Impulse);
        Debug.Log("Goal");
    }
}
