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
    public TileBase redFlower;
    GameObject CarbonScore;

    // Start is called before the first frame update
    void Start()
    {
        tilemap = GameObject.FindGameObjectWithTag("Tilemap").GetComponent<Tilemap>();
        grid = GameObject.FindGameObjectWithTag("Grid").GetComponent<Grid>();
        CarbonScore = GameObject.FindGameObjectWithTag("Score");
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
                                tilemap.SetTile(gridPosition, redFlower);
                                CarbonScore.GetComponent<Score>().score = CarbonScore.GetComponent<Score>().score -5;
                        break;
                        case "wateredPlatedBlueSeed":
                            tilemap.SetTile(gridPosition, blueFlower);
                            CarbonScore.GetComponent<Score>().score = CarbonScore.GetComponent<Score>().score -7;
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
