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
        //if ()
        timeTotal.text = ("You found the items in " + ((int)(globalVariables.timer)).ToString() + " seconds! \n \nNew high score!");

    }
}
