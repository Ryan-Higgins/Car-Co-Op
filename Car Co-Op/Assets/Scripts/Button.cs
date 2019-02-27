using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{

    private void Start()
    {
        anim = GetComponent<Animator>(); 
    }
    bool gate = false;

    Animator anim;
    public Animator gateAnim; 
    private void OnTriggerEnter(Collider other)
    {
        gate = !gate;
        gateAnim.SetBool("Open", gate);
        anim.SetBool("Down", true);
    }
    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("Down", false);
    }
}
