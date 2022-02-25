using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{

    //Get the objects

    

    public GameObject Menu;
    public GameObject PauseObj;

    //Close menu at start

    private void Start()
    {

        Menu.SetActive(false);

    }

    //Open the menu
    
    public void OpenMenu()
    {


        Menu.SetActive(true);

        PauseObj.SetActive(false);

        Debug.Log("Open menu");

    }

    public void CloseMenu()
    {


        Menu.SetActive(false);

        PauseObj.SetActive(true);

    }
}
