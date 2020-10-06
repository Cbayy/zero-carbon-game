using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class Events : MonoBehaviour
{

    Tilemap tilemap;
    Grid grid;

    BoundsInt bounds;
    TileBase[] allTiles;

    public TileBase blueFlower;

    // Start is called before the first frame update
    void Start()
    {
        tilemap = GameObject.FindGameObjectWithTag("Tilemap").GetComponent<Tilemap>();
        grid = GameObject.FindGameObjectWithTag("Grid").GetComponent<Grid>();

        bounds = tilemap.cellBounds;
        allTiles = tilemap.GetTilesBlock(bounds);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void grow(){
        for (int x = -50; x < 100; x++) {
            for (int y = -50; y < 100; y++) {
                Vector3Int gridPosition = new Vector3Int(x,y,0);
                TileBase tile = tilemap.GetTile(gridPosition);
                if (tile != null) {
                    switch (tile.name)
                    {
                        case "wateredPlantedEcSeed":
                            tilemap.SetTile(gridPosition, blueFlower);
                        break;
                        default:
                        break;
                    }
                } else {

                }
            }
        }     
    }
}
