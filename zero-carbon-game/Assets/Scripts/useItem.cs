using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class useItem : MonoBehaviour
{

    private Inventory inventory;

    public Tilemap tilemap;

    public Grid grid;

    private bool placing = false;

    int i = 1;

    private void Start(){
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        tilemap = GameObject.FindGameObjectWithTag("Tilemap").GetComponent<Tilemap>();
        grid = GameObject.FindGameObjectWithTag("Grid").GetComponent<Grid>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            print("aa" + this.name);
                placing = true;
        }
    }

    void FixedUpdate(){
            if(Input.GetMouseButtonDown(0) && placing == true){
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Vector3 worldPoint = ray.GetPoint(-ray.origin.z / ray.direction.z);
                Vector3Int position = grid.WorldToCell(worldPoint);
                Debug.Log(position);
                placing = false;
                //this.GameObject.destroy;
            }
    }

}
