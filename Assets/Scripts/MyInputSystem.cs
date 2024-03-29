using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public delegate void Function();
public class Action 
{
    public string actionName;
    public Function function;
    public KeyCode keyCode;
}

public class MyInputSystem : MonoBehaviour
{
    public Dictionary<int,Action> actions;
    public int actionAmount;

    public void CreateAction(string actionName, Function func, KeyCode keyCode)
    {
        Action createdAction = new Action();
        createdAction.actionName = actionName;
        createdAction.function = func;
        createdAction.keyCode = keyCode;
        actions[actionAmount] = createdAction;
        actionAmount++;
    }
    
    public void ExecuteAction(int index) 
    {
        actions[index].function();
    }
}
