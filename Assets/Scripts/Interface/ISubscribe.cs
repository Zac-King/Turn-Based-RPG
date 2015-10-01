using UnityEngine;
using System.Collections;

public interface ISubscriber
{
    void Subscribe(string a, string e);
    void Recieve(string a);
}