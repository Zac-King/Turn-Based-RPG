//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;

//public class EventSystem : MonoBehaviour
//{
//    [System.Serializable]
//    private class Listener                                                                          // [Class] // Listener 
//    {
//        public string       _event;                 // [Variable] // Stores reference to message
//        public ISubscriber  _subscriber;            // [Variable] // Stores reference to Subscriber

//        public Listener()                           // [Function] // Default Constructor
//        {}

//        public Listener(string e, ISubscriber s)    // [Function] // Custom Constructor
//        {
//            this._event = e;
//            this._subscriber = s;
//        }
//    }

//    [SerializeField]
//    private List<Listener> _subscribers = new List<Listener>();                                     // [Variable] // List of // Who is subscribed, and what they are Subscribed to

//    public void Notify(string message)                                                              // [Function] // Notifies Subscribers
//    {
//        NotifySubs(message);
//    }

//    private void NotifySubs(string message)                                                         // [Function] // Notify all subscribers of the message
//    {
//        foreach (Listener l in _subscribers)
//        {
//            if (l._event == message)
//            {
//                Debug.Log("Notify subs " + l._event);   // Debug Message
//                l._subscriber.Recieve(message);         // Have them receive the brodcasted Message and react
//            }
//        }
//    }               

//    public void AddSubscriber(string t/*Type*/, string e/*Event*/, ISubscriber s/*Subscriber*/)     // [Function] // 
//    {
//        string type = t;
//        string message = e;
//        string subscription = type + ":" + message;
//        AddListener(subscription, s);
//    }

//    private void AddListener(string e/*Event*/, ISubscriber s/*Subscriber*/)                        // [Function] // 
//    {
//        Listener l = new Listener(e, s);
//        _subscribers.Add(l);
//    }

//    public void RemoveSubscriber(string e/*Event*/, ISubscriber s/*Subscriber*/)                    // [Function] // 
//    {
//        Listener l = new Listener(e, s);
//        _subscribers.Remove(l);
//    }

//}
