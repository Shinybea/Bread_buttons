using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

[CreateAssetMenu(fileName = "Event Manager", menuName = "ScriptableObjects/EventManager")]

public class EventManager : ScriptableObject
{
    public Action buttonPressedEvent;
    
    public void OnButtonPressed()
    { 
        buttonPressedEvent?.Invoke();
        Debug.Log("Button Pressed");
    }
}
