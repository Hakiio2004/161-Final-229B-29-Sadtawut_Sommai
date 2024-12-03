using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    public int pownlevel;
    public virtual void Cast()
    {
        Debug.Log($"Spell-Casting Simulation Started ");
        Debug.Log($"Casting a generic spell");
    }
    public string Cast()
    {
        Debug.Log($"");
    }
  
}
