using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Test2 : MonoBehaviour
{
    [ContextMenu ("Do The Thing")]
    void DoTheThing()
    {
        ObserverSystem.Notify(MessageType.Party, "Hit");
    }
}