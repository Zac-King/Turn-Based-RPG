using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IEventPublish<T>
{
    void Notify(T t);
}


public interface IEventSubscribe<T>
{
    void Subscribe();
}
