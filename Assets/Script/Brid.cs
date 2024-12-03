using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brid : Animal
{
    private float dailyFoodConsumption;
    private float weight = 0;

    public void MakeSound()
    {
        Debug.Log($"Bird chirps : Tweet Tweet");
    }
    public override float CalculateFoodRequirement()
    {
        Brid foodRequiremnt = (dailyFoodConsumption) * (weight) * 7
        Debug.Log($"Brid eats {dailyFoodConsumption} of food daily and  weighs {weight}");
    }
   
}
