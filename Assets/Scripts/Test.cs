using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Test : MonoBehaviour
{
    public MessageType testType;
    public string testMessage; 

    void Start()
    { 
        EventSystem.AddSubscriber<string>(testType, testMessage, test1Func);
    }

    void test1Func(string s)
    {
        Debug.Log("Test1Func Called\n" + s);
    }

    [ContextMenu("Die")]
    void Die()
    {
        EventSystem.RemoveSubscriber<string>(testType, testMessage, test1Func);
    }
}