using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum Santa
{
    red, //0 
    green, //1
    gold //2
};
public class GameMaster : MonoBehaviour
{
    public Color stopSign;
    public int state;
    public int points;
    public float period;
    public GameObject colorSign;

    // Start is called before the first frame update
    void Start()
    {
       
   
    }

    // Update is called once per frame
    void Update()
    {
        if (period > Random.Range(4, 10))
        {
            int nbr = Random.Range(0, 3);
            if (nbr == (int)Santa.red)
            {
                stopSign = Color.red;
                colorSign.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
                state = nbr;
            }
            else if (nbr == (int)Santa.green)
            {
                stopSign = Color.green;
                colorSign.GetComponent<Renderer>().material.color = new Color(0, 255, 0);
                state = nbr;
            }
            else if (nbr == (int)Santa.gold)
            {
                stopSign = Color.yellow;
                colorSign.GetComponent<Renderer>().material.color = new Color(255, 255, 0);
                state = nbr;
            }
            period = 0;
        }
        period += UnityEngine.Time.deltaTime;
        TextMesh textObject = GameObject.Find("Points").GetComponent<TextMesh>();
        textObject.text = "Points:" + points.ToString();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (state == (int)Santa.green)
        {
            Debug.Log("Hit " + other.name);
            points++;
        }
        else if (state == (int)Santa.red)
        {
            Debug.Log("Game Over" + points);
            points = 0;
        }
        else if (state == (int)Santa.gold)
        {
            Debug.Log("HitDouble" + other.name);
            points = points + 2;
        
        }
       

 
        
    }
}
