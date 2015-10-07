using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class ObserverSystem
{
    static Dictionary<string, Callback> _subscribers = new Dictionary<string, Callback>();

    public static void Notify(string message)                      // [Function] // Notify all subscribers of the message
    {
        _subscribers[message]();    // Performs all the messages stored in the Delegate at [message]
    }

    public static void AddSubscriber(string e, Callback c)         // [Function] // Add Subscriber to the Dictionary
    {
        if(_subscribers[e] == null) // If the Key doesn't exist; add the key and value pair to the dictionary
            _subscribers.Add(e, c);

        else                        // If Key exists: add the Delegate to the Keys Value
            _subscribers[e] = (Callback)_subscribers[e] + c;
    }

    public static void RemoveSubscriber(string e, Callback c)      // [Function] // Remove Delegate at the Key [e]
    {
        if (_subscribers[e] == null)                        // If Nothing at that Key; do nothing
            return;

        _subscribers[e] = (Callback)_subscribers[e] - c;    // Remove delegate from 

        if((Callback)_subscribers[e] == null)               // If there is no value for the Key aftr the remove; Delete the whole thing
        {
            _subscribers.Remove(e);
        }
    }

}