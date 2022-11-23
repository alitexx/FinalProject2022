using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//public class NumberWizard : MonoBehaviour
//{
//    [SerializeField] TextMeshProUGUI m_Object;

//    void Start()
//    {
//        m_Object..text = "Enter Your Text Here";
//    }
//}

public class itemManager : MonoBehaviour
{
    private int[] randomNumbers = new int[] {0,0,0,0,0};

    [SerializeField] TextMeshProUGUI item1, item2, item3, item4, item5;


    void generateRandomNumbers(int position)
    {
        for (int i = position; i < 5; i++)
        {
            int randomNum = (int)(Random.Range(1.0f, 10.0f));
            for (int j = 0; j < randomNumbers.Length; j++)
            {
                if (randomNum == randomNumbers[j])
                {
                    // position is used so we dont keep on overwriting the same values
                    generateRandomNumbers(position);
                    return;
                }
            }
            position++;
            randomNumbers[i] = randomNum;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        globalVariables.timer = 1;
        var itemsDict = new Dictionary<int, string>() // holds the key and the item 
        {
            { 1, "Item1" }, // change name according to whatever the item is
            { 2, "Item2" },
            { 3, "Item3" },
            { 4, "Item4" },
            { 5, "Item5" },
            { 6, "Item6" },
            { 7, "Item7" },
            { 8, "Item8" },
            { 9, "Item9" },
            { 10, "Item10" }
        };

        generateRandomNumbers(0);

        Debug.Log("numbers being generated....");

        // changes text on the list to fit the ones generated
        item1.text = itemsDict[randomNumbers[0]];
        item2.text = itemsDict[randomNumbers[1]];
        item3.text = itemsDict[randomNumbers[2]];
        item4.text = itemsDict[randomNumbers[3]];
        item5.text = itemsDict[randomNumbers[4]];

    }

    // item value vvv corresponds with the key,
    // if the key = the item value and is actively
    // sought after then the player found the item
    public void itemClicked(int itemLocation) 
    {
        Debug.Log("I have been clicked!");
        int valueFoundAt = -1; // used for position
        for(int i = 0; i < globalVariables.itemsToCollect.Length; i++)
        {
            if (randomNumbers[i] == itemLocation) // if one of the ints we pulled is equal to the passed in int
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
        } else
        {
            Debug.Log("Item has NOT been found!");
            // turn the item's collider red
            // maybe play an error sound or smth
        }
    }

    public void itemFound(int valueFoundAt) // only fires when an item is found, removes it from the list
    {
        randomNumbers[valueFoundAt] = -1;
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
