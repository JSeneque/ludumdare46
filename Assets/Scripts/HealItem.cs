using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealItem : Interactable
{

    protected override void Use()
    {
        Instantiate(effect, player.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
