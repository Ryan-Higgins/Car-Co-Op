using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDetector : MonoBehaviour
{
    public int playerCount = 0;
    public GameObject meDisplay;
     Text text;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<Text>();
        text.text = "";
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
            } else if (gameObject.CompareTag("Left"))
            {
                //SwitchManager.left = true;
                SwitchManager.doubleLeft = true;
            }else if (gameObject.CompareTag("Right"))
            {
                print("CHECKED");
                //SwitchManager.right = true;
                SwitchManager.doubleRight = true;
            }else if (gameObject.CompareTag("Horn"))
            {
                
            }
        } else if (playerCount == 1)
        {
            meDisplay.SetActive(false);
            text.text = gameObject.tag.ToUpper(); 
            //print("Active");
            if (gameObject.CompareTag("Go"))
            {
                SwitchManager.isGoing = true;
                SwitchManager.doubleSpeed = false;
            }else if (gameObject.CompareTag("Stop"))
            {
                SwitchManager.isStopping = true;
                SwitchManager.doubleStop = false;
            } else if (gameObject.CompareTag("Left"))
            {
                SwitchManager.left = true;
                SwitchManager.doubleLeft = false;
            }else if (gameObject.CompareTag("Right"))
            {
                SwitchManager.right = true;
                SwitchManager.doubleRight = false;
            } else if (gameObject.CompareTag("Horn"))
            {
                
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
            }else if (gameObject.CompareTag("Left"))
            {
                SwitchManager.left = false;
                SwitchManager.doubleLeft = false;
            }else if (gameObject.CompareTag("Right"))
            {
                SwitchManager.right = false;
                SwitchManager.doubleRight = false;
            }else if (gameObject.CompareTag("Horn"))
            {
                
            }
        }
    }

   

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.CompareTag("Player1") || player.CompareTag("Player2"))
        {
            playerCount = playerCount + 1;
            meDisplay.SetActive(false);
            text.text = gameObject.tag.ToUpper(); 
        }
    }
    
    void OnTriggerStay2D(Collider2D player)
    {
        print(playerCount);
        
/*        if (player.CompareTag("Player1") || player.CompareTag("Player2"))
        {
            //SwitchManager.isGoing = true;
            //print("Active");
            
            meDisplay.SetActive(false);
            text.text = gameObject.tag.ToUpper(); 
            switch (gameObject.tag)
            {



                case "Go":
                    if (playerCount == 2)
                    {
                        SwitchManager.doubleSpeed = true;
                    }
                    else
                    {
                        SwitchManager.doubleSpeed = false;
                    }
                    //SwitchManager.doubleSpeed = true;
                    //print("Go");
                    SwitchManager.isGoing = true;
                    break;

                case "Stop":
                    if (playerCount == 2)
                    {
                        SwitchManager.doubleStop = true;
                    }
                    else
                    {
                        SwitchManager.doubleStop = false;
                    }
                    print("Stop");
                    SwitchManager.isStopping = true;
                    break;

                case "Left":
                    if (playerCount == 2)
                    {
                        SwitchManager.doubleLeft = true;
                    }
                    else
                    {
                        SwitchManager.doubleLeft = false;
                    }
                    print("Left");
                    SwitchManager.left = true;
                    break;

                case "Right":
                    if (playerCount == 2)
                    {
                        SwitchManager.doubleRight = true;
                    }
                    else
                    {
                        SwitchManager.doubleRight = false;
                    }
                    print("Right");
                    SwitchManager.right = true;
                    break;

                default:

                    print("Shasha Away");
                    break;






            }
        }*/
    }

    void OnTriggerExit2D(Collider2D player)
    {
        playerCount = playerCount - 1;
        text.text = ""; 
        meDisplay.SetActive(true);
        /*if (player.CompareTag("Player1") || player.CompareTag("Player2"))
        {
            //SwitchManager.isGoing = false;
            playerCount = playerCount - 1;
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
        }*/
    }
}
