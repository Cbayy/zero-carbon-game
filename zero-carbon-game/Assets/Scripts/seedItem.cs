using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class seedItem : MonoBehaviour
{
    private Inventory inventory;
    public Tilemap tilemap;

    public Grid grid;

    //private bool placing = false;

    public TileBase plantedEcSeed;

    public seedItem button;

    //new private string name;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        tilemap = GameObject.FindGameObjectWithTag("Tilemap").GetComponent<Tilemap>();
        grid = GameObject.FindGameObjectWithTag("Grid").GetComponent<Grid>();
        //button = GameObject.FindGameObjectWithTag("Slot").GetComponent<Image>();
        //gameObject.name = GetInstanceID().ToString();
        //name = gameObject.name;
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
                        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                        Vector3 worldPoint = ray.GetPoint(-ray.origin.z / ray.direction.z);
                        Vector3Int position = grid.WorldToCell(worldPoint);

                        //placing = false;
                        //tilemap.SetTile(position, plantedEcSeed);
                        TileBase clickedTile = tilemap.GetTile(position);
                        getTile(clickedTile, position);

                        wait = false;
                        
                        
            }
            yield return null;
        }
    }        

    public void getTile(TileBase current, Vector3Int gridPosition){
        
        string tileName = current.name;
        print("TTT: " + tileName);
        
        switch (tileName)
        {
            case "sand01":
                tilemap.SetTile(gridPosition, plantedEcSeed);
                Destroy(gameObject);
                break;
            default:
            break;
        }
    }

/*

    void Update(){
        if(Input.GetMouseButtonDown(0) && placing == true){
                    //button = GameObject.FindGameObjectWithTag("Slot").GetComponent<Image>();
                    button = this;
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    Vector3 worldPoint = ray.GetPoint(-ray.origin.z / ray.direction.z);
                    Vector3Int position = grid.WorldToCell(worldPoint);

                    placing = false;
                    tilemap.SetTile(position, grassSprite);
                    print("NAME:  " + gameObject.name);
                    Destroy(GameObject.Find(name));
                    
                }
    }
    */

//CHANGE TO CLICKED
/*
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2)){
            print("aa" + this.name);
                placing = true;
                print("ITS: " + gameObject.name);
        }

    }
*/

}
