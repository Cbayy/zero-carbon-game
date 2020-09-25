using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class seedItem : MonoBehaviour
{
        private Inventory inventory;
    public Tilemap tilemap;

    public Grid grid;

    private bool placing = false;

    public TileBase grassSprite;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        tilemap = GameObject.FindGameObjectWithTag("Tilemap").GetComponent<Tilemap>();
        grid = GameObject.FindGameObjectWithTag("Grid").GetComponent<Grid>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            print("aa" + this.name);
                    print("THIS: " + inventory.slots[0].name);
                placing = true;
        }

    }

    void FixedUpdate(){
            if(Input.GetMouseButtonDown(0) && placing == true){
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                Vector3 worldPoint = ray.GetPoint(-ray.origin.z / ray.direction.z);
                Vector3Int position = grid.WorldToCell(worldPoint);
                Debug.Log(position);
                print("YEET" + this.name);
                placing = false;
                tilemap.SetTile(position, grassSprite);
                Destroy(gameObject);
            }
    }
}
