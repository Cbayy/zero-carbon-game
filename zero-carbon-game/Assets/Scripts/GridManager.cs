using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    int columns = 20;
    int rows = 20;
    float tileSize = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        generateGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void generateGrid(){
        //GameObject referenceTile = (GameObject)Instantiate(Resources.load("tilename)); add tile sprite
        for(int row = 0; row < rows; row++){
            for(int column = 0; column < columns; column++){

            }
        }
    }
}
