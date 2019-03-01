using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spark : MonoBehaviour
{
    public Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.name == "Alien 1")
        {
            myAnim.SetInteger("Alien", 1);
        } else if (gameObject.name == "Alien 2")
        {
            myAnim.SetInteger("Alien", 2);
        }
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D button)
    {
        if (button.name.Contains("Button"))
        {
            myAnim.SetBool("onWire", false);
        }
        
    }

    void OnTriggerExit2D(Collider2D button)
    {
        if (button.name.Contains("Button"))
        {
            myAnim.SetBool("onWire", true);
        }
    }
}


