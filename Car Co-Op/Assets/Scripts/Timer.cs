using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timer;
    public Text laps;
    public int lapCount = 0;
    private bool startTime;
    public GameObject panel;
    public Text finalTime;

    public Stopwatch time;

    // Start is called before the first frame update
    void Start()
    {
        
        time = new Stopwatch();
        startTime = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime)
        {
            time.Start();
            timer.text = time.Elapsed.ToString("mm\\:ss\\.ff");   
        }

        if (lapCount >= 3)
        {
            print("Race Finished");
            startTime = false;
            time.Stop();
            finalTime.text = time.Elapsed.ToString("mm\\:ss\\.ff");
            panel.SetActive(true);
            Time.timeScale = 0;
        }

        if (Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("Main");
            Time.timeScale = 1;
            lapCount = 0;
        }
    }

    void OnTriggerEnter(Collider ship)
    {
        if (ship.CompareTag("Ship"))
        {
            lapCount++;
            laps.text = "Lap: " + lapCount + "/3";
            startTime = true;
        }
    }
}
