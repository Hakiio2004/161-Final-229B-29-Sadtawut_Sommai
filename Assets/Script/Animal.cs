using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Emit;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;
    public void Init()
    {
        animalName = "";
    }
    public abstract float CalculateFoodRequirement();
    
    public void MakeSound() 
    {
        Debug.Log($"The animal makes a sound ");
    }
    public void DisplayName() 
    {
        Debug.Log($"This is {animalName}");
    }
}
