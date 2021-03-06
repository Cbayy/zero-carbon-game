﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class HarvestTile : MonoBehaviour
{

    private Inventory inventory;
    public Tilemap tilemap;
    public Grid grid;

    public GameObject seed;
    public GameObject blueSeed;
    private Transform player;
    
    GameObject CarbonScore;

    public TileBase plantedEcSeed;
    public TileBase plantedBlueSeed;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        tilemap = GameObject.FindGameObjectWithTag("Tilemap").GetComponent<Tilemap>();
        grid = GameObject.FindGameObjectWithTag("Grid").GetComponent<Grid>();  
        CarbonScore = GameObject.FindGameObjectWithTag("Score");
        player = GameObject.FindGameObjectWithTag("Player").transform;  
        seed = GameObject.FindGameObjectWithTag("Seed");
        blueSeed = GameObject.FindGameObjectWithTag("BlueSeed");
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
        Vector2 playerPos = new Vector2(player.position.x, player.position.y - 2);        
        switch (tileName)
        {
            case "blueFlowerSand":
                tilemap.SetTile(gridPosition, plantedBlueSeed);
                CarbonScore.GetComponent<Score>().score = CarbonScore.GetComponent<Score>().score + 7;
                blueSeed = GameObject.FindGameObjectWithTag("BlueSeed"); 
                Instantiate(blueSeed, playerPos, Quaternion.identity);
                break;
            case "redFlowerSand":
                tilemap.SetTile(gridPosition, plantedEcSeed);
                CarbonScore.GetComponent<Score>().score = CarbonScore.GetComponent<Score>().score + 5;
                seed = GameObject.FindGameObjectWithTag("Seed"); 
                Instantiate(seed, playerPos, Quaternion.identity);
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
