using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimControl : MonoBehaviour
{
    public GameObject theNPC;
    void Update()
    {
        if (Input.GetButtonDown("1Key"))
        {
            theNPC.GetComponent<Animator>().Play("Attack");
        }
        if (Input.GetButtonDown("2Key"))
        {
            theNPC.GetComponent<Animator>().Play("Block");
        }
        if (Input.GetButtonDown("3Key"))
        {
            theNPC.GetComponent<Animator>().Play("Jumping");
        }
        if (Input.GetButtonDown("4Key"))
        {
            theNPC.GetComponent<Animator>().Play("Sword");
        }
    }
}
