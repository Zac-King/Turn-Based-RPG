using UnityEngine;
using System.Collections;

enum CombatStates
{
    IDLE,
    HIT,
    ATTACK,
    BLOCK,
    DIE
}

public class Unit : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        _health = _maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    [SerializeField]
    private int _maxHealth;
    private int _health;

    [SerializeField]
    private float _speed = 0f;
    private float _speedModifier = 0f;

    [SerializeField]
    private float _strength = 0f;
    private float _strengthModifier = 0f;

    [SerializeField]
    private float _defence;
    private float _defenceModifier = 0f;

    private FiniteStateMachine<CombatStates> _fsm = new FiniteStateMachine<CombatStates>();
}
