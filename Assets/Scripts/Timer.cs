using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float period;
    public bool isTimeron;
    // Start is called before the first frame update
    GameMaster myMaster;
    void Start()
    {
        myMaster = GetComponent<GameMaster>();
        myMaster.enabled = false;


    }

    public void StartTimer()
    {
        isTimeron = true;
    }
    public void StopTimer()
    {
        isTimeron = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (period > 600)
        {

            myMaster.enabled = false;

        }
        if (isTimeron == true)
        {
            Debug.Log("TimerRunning");


            period += UnityEngine.Time.deltaTime;
        }
        if (isTimeron == false)
        {
            Debug.Log("TimerNotRunning");


            period = 0;
        }

    }
}
