using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class winScreen : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timeTotal;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        // if high score is beaten
        if (globalVariables.timer > globalVariables.bestTimeLevel1)
        {
            timeTotal.text = ("You found the items in " + ((int)(globalVariables.timer)).ToString() + " seconds! \n \nNew high score!");
        }
        else // if high score was NOT beaten
        {
            timeTotal.text = ("You found the items in " + ((int)(globalVariables.timer)).ToString() + " seconds! \n \nHigh Score: " + ((int)(globalVariables.bestTimeLevel1)).ToString());

        }
    }
}
