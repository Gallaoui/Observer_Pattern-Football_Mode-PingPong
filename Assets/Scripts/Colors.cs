using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour, IObserver
{
    public ColorManager publisher;
    [SerializeField] protected Material c;
    private void Awake()
    {
        publisher.AddObserver(this);
    }

    public void UpdateObserver(Material newMaterial)
    {
        c = newMaterial;
    }

}