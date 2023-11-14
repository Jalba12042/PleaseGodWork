using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PauseScreen : MonoBehaviour
{
    public Canvas CanvasObject;
    //how many memories the player currently has
    public int memAmount = 0;
    public TMP_Text memText;

    void Start()
    {
        CanvasObject.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {
        memText.text = "Memories Collected: " + memAmount;

        //if press escape and canvas is false
        if (Input.GetKeyDown(KeyCode.Escape) && (CanvasObject.GetComponent<Canvas>().enabled == false))
        {
            //enable canvas
            CanvasObject.GetComponent<Canvas>().enabled = true;
        }
        //if press escape and canvas is true
        else if (Input.GetKeyDown(KeyCode.Escape) && (CanvasObject.GetComponent<Canvas>().enabled == true))
        {
            //disable canvas
            CanvasObject.GetComponent<Canvas>().enabled = false;
        }
    }

    public void setMem(int amt)
    {
        memAmount = amt;
    }

    public int getMem()
    {
        return memAmount;
    }

    public void incrementMem()
    {
        memAmount++;
    }
}
