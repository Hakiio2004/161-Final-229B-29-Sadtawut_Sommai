using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption;
    private int activityLevel;

    public void MakeSound()
    {
        Debug.Log($"Dog bark : Woof Woof ");
    }
    public override float CalculateFoodRequirement()
    {
        Dog FoodRequirement = (dailyFoodConsumption) * activityLevel *7;
        Debug.Log($"Dog eats  {dailyFoodConsumption} of food daily with activity{activityLevel} ");
    }
   
}
