using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public Color stopSign;
    public bool hit;
    public Collider hitBox;
    public int points;
    public Collider fist;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        hit = true;
        stopSign = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (hit == false)
        {
            stopSign = Color.red;
        }
        else
        {
            stopSign = Color.green;
        }
     
    }
    public void OnTriggerEnter(Collider other)
    {
        if (hit == true)
        {
            Debug.Log("Hit " + other.name);
            points++;
        }
        else 
        {
            Debug.Log("Game Over" + points);
            points = 0;
        }
       

 
        
    }
}
