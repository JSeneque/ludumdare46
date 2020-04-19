﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public GameObject effect;
    protected Transform player;

    protected virtual void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public virtual void Use()
    {
        Destroy(gameObject);
    }
}
