using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class RayCastingMouseDetection : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    string pastHit = "IAMASTRING";
    [SerializeField] TextMeshProUGUI item1, item2, item3, item4, item5;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 5f))
        {
            //Debug.Log(pastHit.Substring(0, 4));
            if (((string)hit.collider.name).Substring(0, 4) == "ITEM"){ // if it hits an item
                (hit.collider.GetComponent<Outline>().OutlineWidth) = 5f;
                if (Input.GetMouseButtonDown(0)) // player has clicked this object
                {
                    //Debug.Log(((string)hit.collider.name).Substring(4, 1));
                    // itemManagerHolder should be the ONLY THING with this tag
                    itemClicked(Int32.Parse(((string)hit.collider.name).Substring(4, 1)));
                    
                }
            } 
            // if the last item was an item, and the current item is not an item
            else if ((pastHit != hit.collider.name) && (pastHit.Substring(0, 4) == "ITEM"))
            {
                //Debug.Log(GameObject.Find(pastHit));
                (GameObject.Find(pastHit).GetComponent<Outline>().OutlineWidth) = 0f;
            }
            pastHit = hit.collider.name;
        }
    }


    // item value vvv corresponds with the key,
    // if the key = the item value and is actively
    // sought after then the player found the item

    public void itemClicked(int itemLocation)
    {
        Debug.Log("I have been clicked!");
        int valueFoundAt = -1; // used for position
        for (int i = 0; i < itemManager.randomNumbers.Length; i++)
        {
            if (itemManager.randomNumbers[i] == itemLocation) // if one of the ints we pulled is equal to the passed in int
            {
                // item has been found!
                valueFoundAt = i;
                break;
            }
        }
        if (valueFoundAt != -1)
        {
            Debug.Log("Item has been found!");
            itemFound(valueFoundAt); // theres a lot that needs to happen, use a new function
        }
        else
        {
            Debug.Log("Item has NOT been found!");
            // turn the item's collider red
            // maybe play an error sound or smth
        }
    }

    public void itemFound(int valueFoundAt) // only fires when an item is found, removes it from the list
    {
        itemManager.randomNumbers[valueFoundAt] = -1;
        // play a happy sfx or someone crossing something out. or both lol
        switch (valueFoundAt)
        {
            case 0:
                item1.fontStyle = FontStyles.Strikethrough;
                break;
            case 1:
                item2.fontStyle = FontStyles.Strikethrough;
                break;
            case 2:
                item3.fontStyle = FontStyles.Strikethrough;
                break;
            case 3:
                item4.fontStyle = FontStyles.Strikethrough;
                break;
            case 4:
                item5.fontStyle = FontStyles.Strikethrough;
                break;
        }
        // find out how to grab an item from the workspace; dont delete, hide.
    }
}