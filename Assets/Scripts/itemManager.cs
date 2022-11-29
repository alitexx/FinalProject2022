using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class itemManager : MonoBehaviour
{
    public static int[] randomNumbers = new int[] {0,0,0,0,0};
    private static readonly Dictionary<int, string> itemsDict = new Dictionary<int, string>() // holds the key and the item 
        {
            { 10, "Cutting Board" }, // change name according to whatever the item is
            { 11, "" },
            { 12, "Red Book" },
            { 13, "Green Book" },
            { 14, "'VICTORY' Book" },
            { 15, "Item5" },
            { 16, "Item6" },
            { 17, "'touchstone' Book" },
            { 18, "Item8" },
            { 19, "'Survive until dawn' Book" },
            { 20, "'MAZE' Book" },
            { 21, "Item9" },
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
            { 32, "Toaster" }
        };

    [SerializeField] TextMeshProUGUI item1, item2, item3, item4, item5;

    void generateRandomNumbers(int position)
    {
        for (int i = position; i < 5; i++)
        {
            int randomNum = (int)(Random.Range(10.0f, 32.0f));
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
