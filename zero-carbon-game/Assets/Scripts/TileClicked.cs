using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileClicked : MonoBehaviour
{

    
    public Tilemap tilemap;
    //public TileBase swappedTile;
    
    public Grid grid;

    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("ru2n");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            /*
            Vector3 pos = Input.mousePosition;
            Vector3Int tilePos = tilemap.WorldToCell(Camera.main.ScreenToWorldPoint(pos));
            tileMap
            */
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldPoint = ray.GetPoint(-ray.origin.z / ray.direction.z);
            Vector3Int position = grid.WorldToCell(worldPoint);
            Debug.Log(position);
            
            tilemap.SetTile(position, null);
        }
        
    }

}
