using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;

    public Text scoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        score = 100;
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Carbon levels: " + score.ToString();
    }
}
