using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureScript : MonoBehaviour
{
    [SerializeField] Text textComponent;


    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = ("Young adventurer! Welcome to the Dragon's Den. Enter if you dare!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
