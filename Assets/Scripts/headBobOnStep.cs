using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headBobOnStep : MonoBehaviour
{
    public Animator camAnim;

    void Update()
    {
        if (globalVariables.itemsCollected < 5) // if they havent found all 5 items yet
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                camAnim.SetTrigger("walk");
            }
            else
            {
                camAnim.SetTrigger("idle");
            }
        }
        else
        {
            camAnim.SetTrigger("idle");
        }
    }
}