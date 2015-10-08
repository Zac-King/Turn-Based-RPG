using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public static class ObserverSystem
{
    private static Dictionary<string, Delegate> _subscribers = new Dictionary<string, Delegate>();
    
    public static void Notify(MessageType t, string m)                                  // [Function] // Notify all subscribers of the message
    {
        string message = FormatMessage(t, m);       // Make formated Message
        Delegate d;                                 // Make a Delegate, to store <Delegate> value

        if (_subscribers.TryGetValue(message, out d))// If Key Exist output the value to d
        {
            Callback c = d as Callback; // Cast d as Callback
            if (c != null)
            {
                c();    // Use the Delegate
            }
        }
    }

    public static void Notify<T>(MessageType t, string m, T arg)                        // [Function] // Notify all subscribers of the message
    {
        string message = FormatMessage(t, m);           // Make formated Message
        Delegate d;                                     // Make a Delegate, to store <Delegate> value

        if (_subscribers.TryGetValue(message, out d))   // If Key Exist output the value to d
        {
            Callback<T> c = d as Callback<T>;   // Cast d as Callback<T>
            if (c != null)
            {
                c(arg);    // Use the Delegate
            }
        }
    }

    public static void AddSubscriber(MessageType t, string m, Callback c)               // [Function] // Add Subscriber to the Dictionary
    {
        string message = FormatMessage(t,m);
        if(!_subscribers.ContainsKey(message)) // If the Key doesn't exist; add the key and value pair to the dictionary
            _subscribers.Add(message, c);

        else                        // If Key exists: add the Delegate to the Keys Value
            _subscribers[message] = (Callback)_subscribers[message] + c;
    }

    public static void AddSubscriber<T>(MessageType t, string m, Callback c, T arg)     // [Function] // Add Subscriber to the Dictionary
    {
        string message = FormatMessage(t, m);
        if (!_subscribers.ContainsKey(message)) // If the Key doesn't exist; add the key and value pair to the dictionary
            _subscribers.Add(message, c);

        else                        // If Key exists: add the Delegate to the Keys Value
            _subscribers[message] = (Callback)_subscribers[message] + c;
    }

    public static void RemoveSubscriber(MessageType t, string m, Callback c)            // [Function] // Remove Delegate from Dictionary
    {
        string message = FormatMessage(t,m);
        if (!_subscribers.ContainsKey(message))                     // If Nothing at that Key; do nothing
            return;

        if (_subscribers[message] != null)
            _subscribers[message] = _subscribers[message] - c;      // Remove delegate from 

        if(_subscribers[message] == null)                           // If there is no value for the Key aftr the remove; Delete the whole thing
        {
            _subscribers.Remove(message);
        }
    }

    private static string FormatMessage(MessageType type, string message)               // [Function] // Ensures Messages are proper Format
    {
        return  type.ToString() + ":" + message;
    }
    
}

//public class Subscriber
//{
//    public MessageType type;
//    public string message;
//    Object callback;

//    Subscriber()
//    {

//    }

//    Subscriber(MessageType t, string s, Callback c)
//    {
//        type = t;
//        message = s;
//        callback = c as Object;
//    }
//}