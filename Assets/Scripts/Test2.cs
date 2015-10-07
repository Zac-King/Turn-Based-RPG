using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Test2 : MonoBehaviour, ISubscriber
{
    
    
    

    [SerializeField]
    private EventSystem _systemHub;

    void Start()
    {
        Callback tester;
        tester = Test2Act;
        Subscribe(gameObject.name, "TestMessage");
        Subscribe("BadGuy", "Punch");
    }

    [ContextMenu ("Test2Act")]
    void Test2Act()
    {
        _systemHub.Notify(gameObject.name + ":TestMessage");
    }

    [ContextMenu ("Test2 Die")]
    void Die()
    {
        _systemHub.RemoveSubscriber(gameObject.name +":TestMessage", this);
        _systemHub.RemoveSubscriber("BadGuy:Punch", this);
    }

    // Subscriber Interface Functions
    public void Recieve(string a)
    {
        Debug.Log(a + " : Received by " + gameObject.name);

        //throw new NotImplementedException();
    }

    public void Subscribe(string a, string e)
    {
        _systemHub.AddSubscriber(a, e, this);

        //throw new NotImplementedException();
    }
}
