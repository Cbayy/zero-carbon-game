using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class exitInventory : MonoBehaviour
{

    public Button button;
    
    public GameObject inventory;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);   
    }

	void TaskOnClick(){
		Debug.Log ("You have clicked the button!");
        inventory.gameObject.SetActive(false);
	}
}

