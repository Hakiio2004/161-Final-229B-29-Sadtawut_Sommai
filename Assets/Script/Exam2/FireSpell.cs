using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public int pownlevel;

    public override void Cast()
    {
        Debug.Log($"Casting a Fireball spell Burn them all");
    }
}
