using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            timer.StartTimer();
        
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            timer.StopTimer();

        }

    }
}
