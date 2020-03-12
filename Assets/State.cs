﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(14,10)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string GetStateStory()
    {
        return storyText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
