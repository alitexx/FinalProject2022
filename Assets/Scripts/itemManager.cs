using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 * how to implement a new item :
 * name it something like "ITEM35_itemDescription"
 * go to the itemsDict and add a new pair, such as { 10, "Cutting Board" },
 * first number is whatever number you put after 35 and the string is the name that shows up in-game
 * make sure the gameObject has a collider (mesh or box), and has the outline script as a component
 * go back into this script and change generateRandomNumbers's  int randomNum's range. so instead of 10 - a number, take that last number and add 1
 * done :)
 * 
 * NOTE: Make sure it isn't being blocked by something, or it is inside another object's collider. that will make it impossible to collect!
 * 
 */
public class itemManager : MonoBehaviour
{
    public static int[] randomNumbers = new int[] {0,0,0,0,0};
    private static readonly Dictionary<int, string> itemsDict = new Dictionary<int, string>() // holds the key and the item 
        {
            { 10, "Cutting Board" }, // change name according to whatever the item is
            { 11, "" }, // we still need an item
            { 12, "Red Book" },
            { 13, "Green Book" },
            { 14, "'VICTORY' Book" },
            { 15, "Potted Plant" },
            { 16, "Bread" },
            { 17, "Apple" },
            { 18, "Canned Food" },
            { 19, "Cooking Oil" },
            { 20, "'MAZE' Book" },
            { 21, "Item9" }, // we still need a 21st item
            { 22, "Coffee Cup" },
            { 23, "Corn Flakes" },
            { 24, "Cereal Bowl" },
            { 25, "Glass" },
            { 26, "Knife" },
            { 27, "Laptop" },
            { 28, "Painting" },
            { 29, "Frying Pan" },
            { 30, "Stack of Plates" },
            { 31, "Spoon" },
            { 32, "Toaster" },
            { 33, "Flour" },
            { 34, "Cookies" },
            { 35, "Candy Bar" },
            { 36, "Chips" },
            { 37, "Pineapple" },
            { 38, "Purple Soda" }
        };

    [SerializeField] TextMeshProUGUI item1, item2, item3, item4, item5;

    void generateRandomNumbers(int position)
    {
        for (int i = position; i < 5; i++)
        {
            int randomNum = (int)(Random.Range(10.0f, 38.0f));
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
        // reset globals
        globalVariables.timer = 0;
        globalVariables.itemsCollected = 0;

        generateRandomNumbers(0);

        // changes text on the list to fit the ones generated
        item1.text = itemsDict[randomNumbers[0]];
        item2.text = itemsDict[randomNumbers[1]];
        item3.text = itemsDict[randomNumbers[2]];
        item4.text = itemsDict[randomNumbers[3]];
        item5.text = itemsDict[randomNumbers[4]];

    }
}
