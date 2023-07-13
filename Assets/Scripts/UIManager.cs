using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    private List<GameObject> userClicks = new List<GameObject>();   
    public void ToggleButton(int num)
    {
        string gameObjectName = "Inventory" + num.ToString();
        Debug.Log(gameObjectName);
        var currBtn = GameObject.Find("Main Camera/Canvas/Inventory/" + gameObjectName);
        userClicks.Add(currBtn);
        int clickNum = userClicks.Count;
        if(clickNum > 1)
        {
            userClicks[clickNum-2].SetActive(false);
        }
        if (currBtn.activeInHierarchy == true)
        {
            currBtn.SetActive(false);
        }
        else
        {
            currBtn.SetActive(true);
        }

    }
}
