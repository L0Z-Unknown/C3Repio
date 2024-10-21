using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        string name = "Jack";
        Debug.Log(name);
        int health = 10;
        Debug.Log(health);
        float crtiChance = 0.2f;
        bool key = true;
        //all of the blow subtract 1 from the value of health
        health = health - 1;
        health -= 1;
        health--;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
