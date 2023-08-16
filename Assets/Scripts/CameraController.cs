using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Variables
    [SerializeField] private float mouseSensitivity;
    [SerializeField] public GameObject inventory;
    [SerializeField] public Inventory inventoryScript;




    //References
    private Transform parent;

    private void Start()
    {
        parent = transform.parent;
        Cursor.lockState = CursorLockMode.Locked;   
    }

    private void Update()
    {
        if(inventoryScript.inventoryEnabled == false)
        {
            Time.timeScale = 1;
            Debug.Log("Inventory Off");
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Rotate();
        }
        else
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Debug.Log("Inventory On");
        }



        
    }

    private void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        parent.Rotate(Vector3.up, mouseX);
    }
}
