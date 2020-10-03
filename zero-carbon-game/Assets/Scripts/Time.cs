using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{

    public Text timeTxt;

    int time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        int result = (time % 10000 >= 5000 ? time + 10000 - time % 10000 : time - time % 10000)/10000;
        
        timeTxt.text = "Day: " + result.ToString();
    }
}
