using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemManager : MonoBehaviour
{
    private int[] randomNumbers = new int[] {0,0,0,0,0};

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

        Debug.Log("I made it to here!");

        generateRandomNumbers(0);

        Debug.Log("numbers being generated....");

        globalVariables.itemsToCollect = new string[] { itemsDict[randomNumbers[0]], itemsDict[randomNumbers[1]], itemsDict[randomNumbers[2]], itemsDict[randomNumbers[3]], itemsDict[randomNumbers[4]] };

        Debug.Log(globalVariables.itemsToCollect[0]);
        Debug.Log(globalVariables.itemsToCollect[1]);
        Debug.Log(globalVariables.itemsToCollect[2]);
        Debug.Log(globalVariables.itemsToCollect[3]);
        Debug.Log(globalVariables.itemsToCollect[4]);

    }

}
