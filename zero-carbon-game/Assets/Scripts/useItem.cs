using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useItem : MonoBehaviour
{

    private Inventory inventory;

    private void Start(){
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)){
            print(this.name);
        }

    }
}
