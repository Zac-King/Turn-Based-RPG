using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EventSystem : MonoBehaviour
{
    private class Listener                                                                  // [Class] // Listener 
    {
        public string _event;                       // [Variable] // Stores reference to message
        public ISubscriber _subscriber;             // [Variable] // Stores reference to Subscriber

        public Listener()                           // [Function] // Default Constructor
        {}

        public Listener(string e, ISubscriber s)    // [Function] // Custom Constructor
        {
            this._event = e;
            this._subscriber = s;
        }
    }

    private List<Listener> _subscribers = new List<Listener>();                             // [Variable] // List of // Who is subscribed, and what they are Subscribed to

    public void Notify(string message)                                                      // [Function] // Notifies Subscribers
    {
        NotifySubs(message);
    }

    private void NotifySubs(string message)                                                 // [Function] // 
    {
        
        foreach(Listener l in _subscribers)
        {
            if(l._event == message)
            {
                Debug.Log("Notify subs " + l._event);
                l._subscriber.Recieve(message);
            }
        }
    }               

    public void AddSubscriber(string t, string e/*Event*/, ISubscriber s/*Subscriber*/)     // [Function] //
    {
        string type = t;
        string message = e;
        string subscription = type + ":" + message;
        AddListener(subscription, s);
    }

    public void AddListener(string e/*Event*/, ISubscriber s/*Subscriber*/)                 // [Function] //
    {
        Listener l = new Listener(e, s);
        _subscribers.Add(l);

    }

    //public void RemoveSubscriber(string e/*Event*/, ISubscriber s/*Subscriber*/)
    //{
    //    Listener l = new Listener(e, s);
    //    _subscribers.Remove(l);
    //}
}
