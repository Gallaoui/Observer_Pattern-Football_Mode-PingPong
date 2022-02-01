using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPublisher
{
    void AddObserver(IObserver observer);

    void RemoveObserver(IObserver observer);

    void NotifyObservers();
}