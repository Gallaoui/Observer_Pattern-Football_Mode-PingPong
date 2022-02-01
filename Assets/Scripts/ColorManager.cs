using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour, IPublisher
{
    private List<IObserver> observers = new List<IObserver>();
    private Material IMaterial;

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var o in observers)
        {
            o.UpdateObserver(IMaterial);
        }
    }
    
    public void SetIColor(Material c, Color cl)
    {
        IMaterial = c;
        c.color = cl;
        NotifyObservers();
    }
    public Material ground;
    public Material pl;
    public Material vs;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SetIColor(pl, Color.yellow);
            SetIColor(vs, Color.gray);
            SetIColor(ground, Color.red);
        }
        if (collision.gameObject.name == "Versus")
        {
            SetIColor(pl, Color.gray);
            SetIColor(vs, Color.yellow);
            SetIColor(ground, Color.blue);
        }

    }

}