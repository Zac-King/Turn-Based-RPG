using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    enum GameState
    {
        INIT,
        RUNNING,
        PAUSED,
        EXIT
    }

    FiniteStateMachine<GameState> _fsm = new FiniteStateMachine<GameState>(); 


    [ContextMenu ("Test1")]
    void testThing()
    {
        _fsm.PrintStates();

        _fsm.AddTransition(GameState.INIT, GameState.RUNNING);
        _fsm.AddTransition(GameState.RUNNING, GameState.PAUSED);
        _fsm.AddTransition(GameState.PAUSED, GameState.RUNNING);
        _fsm.AddTransition(GameState.PAUSED, GameState.EXIT);
    }

    [ContextMenu("Test2")]
    void testThing2()
    {
        _fsm.Transition(GameState.RUNNING);     // Happens
        _fsm.Transition(GameState.PAUSED);      // Happens
        _fsm.Transition(GameState.INIT);        // Fails
    }
}
