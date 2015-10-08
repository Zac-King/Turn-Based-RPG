using UnityEngine;
using System.Collections;

public interface ISubscriber
{
    void Subscribe(MessageType type, string message, Callback callback);
}