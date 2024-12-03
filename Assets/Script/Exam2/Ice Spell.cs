using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    public int pownlevel;
    public override void Cast()
    {
        Debug.Log($"Casting an ice shard spell Freeze the enemy");
    }
}
