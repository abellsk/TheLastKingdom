using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public bool inventoryEnabled;
    public GameObject inventory;
   

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.I))
            inventoryEnabled = !inventoryEnabled;
      



        if (inventoryEnabled == true)
        {
            inventory.SetActive(true);
            
        }

       else
        {
            inventory.SetActive(false);
            
        }
    }

    
}
