using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{

    public Text timeTxt;

    int time, pastResult;

    GameObject EventSystem;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        pastResult = 0;

        EventSystem = GameObject.FindGameObjectWithTag("EventSystem");
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        int result = (time % 10000 >= 5000 ? time + 10000 - time % 10000 : time - time % 10000)/10000;
        if(pastResult < result){
            print("Day passed");
            EventSystem.GetComponent<Events>().grow();
        }
        
        pastResult = result;
        timeTxt.text = "Day: " + result.ToString();
    }
}
