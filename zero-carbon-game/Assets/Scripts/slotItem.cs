using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotItem : MonoBehaviour
{
    private Inventory inventory;
    public int i;
    
    void Start() {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    void Update(){
        if(transform.childCount <= 0){
            inventory.isFull[i] = false;
        }
    }
}
