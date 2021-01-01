using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class Score : MonoBehaviour
{
    public int score;

    public Text scoreTxt;
    public Tilemap gate;

    // Start is called before the first frame update
    void Start()
    {
        score = 100;
        gate = GameObject.FindGameObjectWithTag("Gate").GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Carbon levels: " + score.ToString();
    }
}
