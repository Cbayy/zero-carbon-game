﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class WaterTile : MonoBehaviour
{

    private Inventory inventory;
    public Tilemap tilemap;
    public Grid grid;

    public TileBase waterSand;
    public TileBase waterEcSeed;
    public TileBase waterBlueSeed;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        tilemap = GameObject.FindGameObjectWithTag("Tilemap").GetComponent<Tilemap>();
        grid = GameObject.FindGameObjectWithTag("Grid").GetComponent<Grid>();
    }

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
            case "sand01":
                tilemap.SetTile(gridPosition, waterSand);
                break;
            case "plantedEcSeed":
                tilemap.SetTile(gridPosition, waterEcSeed);
                break;
            case "plantedBlueSeed":
                tilemap.SetTile(gridPosition, waterBlueSeed);
                break;
            default:
            break;
        }
    }
}
