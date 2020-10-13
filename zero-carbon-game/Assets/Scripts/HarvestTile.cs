using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class HarvestTile : MonoBehaviour
{

    private Inventory inventory;
    public Tilemap tilemap;
    public Grid grid;

    
    GameObject CarbonScore;

    public TileBase plantedEcSeed;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        tilemap = GameObject.FindGameObjectWithTag("Tilemap").GetComponent<Tilemap>();
        grid = GameObject.FindGameObjectWithTag("Grid").GetComponent<Grid>();  
        CarbonScore = GameObject.FindGameObjectWithTag("Score");    
    }

    //Can prob combine below code with that in waterTile
    public void Use(){
        StartCoroutine("WaitForAnswer");
    }

    public IEnumerator WaitForAnswer()
    {
        bool wait = true;
        while(wait){
            if (Input.GetMouseButtonDown(0))
            {
                        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                        Vector3Int gridPosition = tilemap.WorldToCell(mousePosition);
                        //tilemap.SetTile(position, grassSprite);
                        TileBase clickedTile = tilemap.GetTile(gridPosition);
                        //TileBase wateredTile = getTile(clickedTile);
                        getTile(clickedTile, gridPosition);
                        wait = false;
                        
            }
            yield return null;
        }
    }

    public void getTile(TileBase current, Vector3Int gridPosition){
        string tileName = current.name;        
        switch (tileName)
        {
            case "blueFlowerSand":
                tilemap.SetTile(gridPosition, plantedEcSeed);
                CarbonScore.GetComponent<Score>().score = CarbonScore.GetComponent<Score>().score + 2;
                break;
            case "redFlowerSand":
                tilemap.SetTile(gridPosition, plantedEcSeed);
                CarbonScore.GetComponent<Score>().score++;
                break;
            default:
            break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
