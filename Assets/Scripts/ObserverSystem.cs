using UnityEngine;
using System.Collections;
using System.Collections.Generic;

static class ObserverSystem
{ 
    static Dictionary<string, Callback> _subscribers = new Dictionary<string, Callback>();


    static void Notify(string message)                      // [Function] // Notify all subscribers of the message
    {
        _subscribers[message]();    // Performs all the messages stored in the Delegate at [message]
    }

    static void AddSubscriber(string e, Callback c)         // [Function] // 
    {
        if(_subscribers[e] == null) // If the Key does not exist, make one
        {
            _subscribers.Add(e, c);
        }

        else                        // If Key already exists, just add the Delegate to the Keys Value
        {
            _subscribers[e] = (Callback)_subscribers[e] + c;
        }
    }

    static void RemoveSubscriber(string e, Callback c)      // [Function] // 
    {
        _subscribers[e] = (Callback)_subscribers[e] - c;
    }

}