using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDetector : MonoBehaviour
{
    public int playerCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<Text>();
        text.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        /*//(playerCount);
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

            //print("Active");
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
            //print("not Active");
            if (gameObject.CompareTag("Go"))
            {
                SwitchManager.isGoing = false;
                SwitchManager.doubleSpeed = false;
            } else if (gameObject.CompareTag("Stop"))
            {
                SwitchManager.isStopping = false;
                SwitchManager.doubleStop = false;
            }
        }*/

        if(playerCount > 0){





        }
    }

    public GameObject meDisplay;
    Text text; 
    
    void OnTriggerStay2D(Collider2D player)
    {
        
        if (player.CompareTag("Player1") || player.CompareTag("Player2"))
        {
            //SwitchManager.isGoing = true;
            //print("Active");
            playerCount++;
            meDisplay.SetActive(false);
            text.text = gameObject.tag.ToUpper(); 
            switch (gameObject.tag)
            {



                case "Go":
                    //SwitchManager.doubleSpeed = true;
                    print("Go");
                    SwitchManager.isGoing = true;
                    break;

                case "Stop":
                    print("Stop");
                    SwitchManager.isStopping = true;
                    break;

                case "Left":
                    print("Left");
                    SwitchManager.left = true;
                    break;

                case "Right":
                    print("Right");
                    SwitchManager.right = true;
                    break;

                default:

                    print("Shasha Away");
                    break;






            }
        }
    }

    void OnTriggerExit2D(Collider2D player)
    {
        if (player.CompareTag("Player1") || player.CompareTag("Player2"))
        {
            //SwitchManager.isGoing = false;
            playerCount--;
            text.text = ""; 
            meDisplay.SetActive(true);

            switch (gameObject.tag)
            {



                case "Go":
                    //SwitchManager.doubleSpeed = true;
                    print("Go");
                    SwitchManager.isGoing = false;
                    break;

                case "Stop":
                    print("Stop");
                    SwitchManager.isStopping = false;
                    break;

                case "Left":
                    print("Left");
                    SwitchManager.left = false;
                    break;

                case "Right":
                    print("Right");
                    SwitchManager.right = false;
                    break;

                default:

                    print("Shasha Away");
                    break;






            }
        }
    }
}
