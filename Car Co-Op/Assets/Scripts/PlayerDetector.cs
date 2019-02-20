using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    public int playerCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(playerCount);
        if (playerCount == 2)
        {
            if (gameObject.CompareTag("Go"))
            {
                SwitchManager.doubleSpeed = true;
                SwitchManager.isGoing = true;
            } else if (gameObject.CompareTag("Stop"))
            {
                SwitchManager.isStopping = true;
                SwitchManager.doubleStop = true;
            }
        } else if (playerCount == 1)
        {
            if (gameObject.CompareTag("Go"))
            {
                SwitchManager.isGoing = true;
                SwitchManager.doubleSpeed = false;
            }else if (gameObject.CompareTag("Stop"))
            {
                SwitchManager.isStopping = true;
                SwitchManager.doubleStop = false;
            }
        } else if (playerCount == 0)
        {
            if (gameObject.CompareTag("Go"))
            {
                SwitchManager.isGoing = false;
                SwitchManager.doubleSpeed = false;
            } else if (gameObject.CompareTag("Stop"))
            {
                SwitchManager.isStopping = false;
                SwitchManager.doubleStop = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D player)
    {
        
        if (player.CompareTag("Player1") || player.CompareTag("Player2"))
        {
            //SwitchManager.isGoing = true;
            playerCount++;
        }
    }

    void OnTriggerExit2D(Collider2D player)
    {
        if (player.CompareTag("Player1") || player.CompareTag("Player2"))
        {
            //SwitchManager.isGoing = false;
            playerCount--;
        }
    }
}
