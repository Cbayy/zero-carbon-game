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
        for (int x = 0; x < bounds.size.x; x++) {
            for (int y = 0; y < bounds.size.y; y++) {
                TileBase tile = allTiles[x + y * bounds.size.x];
                if (tile != null) {
                    Vector3Int gridPosition = new Vector3Int(x,y,0);
                    switch (tile.name)
                    {
                        case "plantedEcSeed":
                        tilemap.SetTile(gridPosition, null);
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
