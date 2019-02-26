using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HonkCheck : MonoBehaviour
{
    public Animator myAnim;

    public GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider ship)
    {
        if (ship.CompareTag("Ship"))
        {
            if (myAnim.GetBool("Open"))
            {
                myAnim.SetBool("Open", false);
                block.GetComponent<BoxCollider>().enabled = true;
            }
        }

    }

    private void OnTriggerStay(Collider ship)
    {
        if (ship.CompareTag("Ship"))
        {
            if (!myAnim.GetBool("Open"))
            {
                if (SwitchManager.horn)
                {
                    myAnim.SetBool("Open", true);
                    block.GetComponent<BoxCollider>().enabled = false;
                }
            }
        }
    }
}
