using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public GameObject potion;

    void PopOutPotion()
    {
        Vector2 pos = new Vector2(transform.position.x + 0.5f, transform.position.y + 0.5f);
        Instantiate(potion, pos, Quaternion.identity);
        
    }
}
