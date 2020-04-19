using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealItem : Interactable
{

    public override void Use()
    {
        base.Use();
        Instantiate(effect, player.position, Quaternion.identity);
        
    }
}
