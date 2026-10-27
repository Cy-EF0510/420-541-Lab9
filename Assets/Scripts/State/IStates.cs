using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public interface IState{
    StateType Type{get;}
    void Enter();
    void Execute();
    void Exit();
}
