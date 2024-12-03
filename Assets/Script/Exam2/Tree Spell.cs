using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpell : Spell
{
    public int pownlevel;
    public override void Cast()
    {
        Debug.Log($"Casting a kick spell the enemy");
    }
}
