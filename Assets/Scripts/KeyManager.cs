using UnityEngine;
using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;

public enum InputKeyBoard           // [ENUM] // All Valid Keys
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
    SPACE,
    ESCAPE,
    SHIFT,
    NUM_LOCK,
    SCROLL_LOCK,
    CAP_LOCK,
    Num_0,
    Num_1,
    Num_2,
    Num_3,
    Num_4,
    Num_5,
    Num_6,
    Num_7,
    Num_8,
    Num_9,
    F1,
    F2,
    F3,
    F4,
    F5,
    F6,
    F7,
    F8,
    F9,
    F10,
    F11,
    F12
}

public class KeyManager : MonoBehaviour
{
    [Serializable]
    private class ValidAction 
    {
        public InputKeyBoard _userInput;
        private bool _pressed;

        public List<string> _action;

        public ValidAction()
        {
            //myActions = new Dictionary<InputKeyBoard, events>();
        }

        public ValidAction(InputKeyBoard k, string m)
        {
            _userInput = k;
            _action.Add(m);
            _pressed = false;
        }

        public InputKeyBoard GetInput()
        {
            return _userInput;
        }

        public void SetPressed(bool b)
        {
            _pressed = b;
        }
    }

    [SerializeField]
    private ValidAction[] _validInputs;

    

    void Awake()
    {
        
    }

    public void ZacdaBest()
    {

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            // stuff
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // stuff
        }
















        foreach (ValidAction b in _validInputs)
        {

            
        //    var values = Enum.GetValues(typeof(InputKeyBoard));
        //
        //    foreach (var v in values)
        //    {
        //        if(b._userInput == (InputKeyBoard)v)
        //        {
        //            // publish b?
        //        }
        //    }        
        //       
        }
    }
    
}


