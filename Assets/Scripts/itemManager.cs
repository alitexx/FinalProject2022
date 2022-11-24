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
    public static int[] randomNumbers = new int[] {0,0,0,0,0};
    private static readonly Dictionary<int, string> itemsDict = new Dictionary<int, string>() // holds the key and the item 
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

        generateRandomNumbers(0);

        Debug.Log("numbers being generated....");

        // changes text on the list to fit the ones generated
        item1.text = itemsDict[randomNumbers[0]];
        item2.text = itemsDict[randomNumbers[1]];
        item3.text = itemsDict[randomNumbers[2]];
        item4.text = itemsDict[randomNumbers[3]];
        item5.text = itemsDict[randomNumbers[4]];

    }
}
