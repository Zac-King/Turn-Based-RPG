using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Test : MonoBehaviour
{
    public MessageType testType;
    public string testMessage; 

    void Start()
    { 
        ObserverSystem.AddSubscriber<string>(testType, testMessage, test1Func);
    }

    void test1Func(string s)
    {
        Debug.Log("Test1Func Called\n" + s);
    }

    [ContextMenu("Die")]
    void Die()
    {
        ObserverSystem.RemoveSubscriber<string>(testType, testMessage, test1Func);
    }
}