using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

// Acting as our Test Generic
public enum Key
{
    A,
    B,
    C,
    D,
    E,
    F,
    G,
    H,
    I,
    J,
    K,
    L,
    M,
    N,
    O,
    P,
    Q,
    R,
    S,
    T,
    U,
    V,
    W,
    X,
    Y,
    Z,
    ARROW_UP,
    ARROW_LEFT,
    ARROW_DOWN,
    ARROW_RIGHT,
    ESCAPE,
    SHIFT,
    NUMLOCK
}
// //////////////////////////

public delegate void Actions();

public class KeyManager<T>
{
    private class Stash
    {
        Callback _stash;

        public Stash()
        {
            
        }

        public void AddAction(Callback a)
        {
            _stash += a;
        }
    }

    Dictionary<T, Stash> KeyRing = new Dictionary<T, Stash>();
 
    public void AddKeyRing(T t, Callback a)
    {
        Stash n = new Stash();
        n.AddAction(a);
        KeyRing.Add(t,n);
    }
 
}






class TestProtectionSceope
{
    TestProtectionSceope ()
    {
        KeyManager<Key> km = new KeyManager<Key>();
        KeyManager<Key>.Stash s = new KeyManager<Key>.Stash();
    }
}


