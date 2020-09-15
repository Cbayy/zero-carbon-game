using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    // Start is called before the first frame update
    
    //Inventory inventory;

    void Start()
    {
        /*
        inventory = Inventory.instance;
        inventory.onItemChangedCallBack += UpdateUI;
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateUI(){
        Debug.Log("Updating UI");
    }
}
