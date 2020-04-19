using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cauldron : MonoBehaviour
{
    public GameObject potion;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void PopOutPotion()
    {
        Vector2 pos = new Vector2(transform.position.x + 0.5f, transform.position.y + 0.5f);
        Instantiate(potion, pos, Quaternion.identity); 
    }

    public void Brew()
    {
        animator.SetBool("brewing", true);
    }
}
