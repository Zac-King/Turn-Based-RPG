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
        Callback c = test1Func;
        ObserverSystem.AddSubscriber(testType, testMessage, test1Func);
    }

    void test1Func()
    {
        Debug.Log("Test1Func Called");
    }

    [ContextMenu("Die")]
    void Die()
    {
        ObserverSystem.RemoveSubscriber(testType, testMessage, test1Func);
    }
}