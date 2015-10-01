using UnityEngine;
using System.Collections;
using System;

public class Test : MonoBehaviour, ISubscriber
{
    private enum TestEvents
    {
        INIT,
        ACT,
        STOP,
        REACT,
        PARTY
    }

    TestEvents myT = TestEvents.INIT;
    public delegate void TestHandler();

    void Awake()
    {
        Subscribe();
    }



    public void Recieve(string a)
    {
        throw new NotImplementedException();
    }

    public void Subscribe(string a, string e)
    {
        throw new NotImplementedException();
    }

    //enum GameState
    //{
    //    INIT,
    //    RUNNING,
    //    PAUSED,
    //    EXIT
    //}

    //FiniteStateMachine<GameState> _fsm = new FiniteStateMachine<GameState>(); 


    //[ContextMenu ("Test1")]
    //void testThing()
    //{
    //    _fsm.PrintStates();

    //    _fsm.AddTransition(GameState.INIT,      GameState.RUNNING);
    //    _fsm.AddTransition(GameState.RUNNING,   GameState.PAUSED);
    //    _fsm.AddTransition(GameState.PAUSED,    GameState.RUNNING);
    //    _fsm.AddTransition(GameState.PAUSED,    GameState.EXIT);
    //}

    //[ContextMenu("Test2")]
    //void testThing2()
    //{
    //    _fsm.Transition(GameState.RUNNING);     // Happens
    //    _fsm.Transition(GameState.PAUSED);      // Happens
    //    _fsm.Transition(GameState.INIT);        // Fails
    //}

}
