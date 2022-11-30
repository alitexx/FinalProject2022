using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pauseManager : MonoBehaviour
{
    [SerializeField] GameObject cam2;
    [SerializeField] GameObject player;
    [SerializeField] GameObject timerObj;
    [SerializeField] Canvas pauseMenu;
    [SerializeField] TextMeshProUGUI levelHS, currentTime, levelHSBG, currentTimeBG;
    [SerializeField] GameObject allClickableObjects;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            togglePause();
        }
    }
    public void togglePause()
    {
        timerObj.SetActive(!timerObj.activeInHierarchy);
        allClickableObjects.SetActive(!allClickableObjects.activeInHierarchy);
        player.SetActive(!player.activeInHierarchy);
        cam2.SetActive(!cam2.activeInHierarchy);
        pauseMenu.enabled = !pauseMenu.enabled;
        if (pauseMenu.enabled == true)
        {
            Cursor.lockState = CursorLockMode.Confined;
            levelHS.text = ("Fastest Time on this level: " + ((int)(globalVariables.bestTimeLevel1)).ToString());
            currentTime.text = ("Current Time: " + ((int)(globalVariables.timer)).ToString());
            levelHSBG.text = ("Fastest Time on this level: " + ((int)(globalVariables.bestTimeLevel1)).ToString());
            currentTimeBG.text = ("Current Time: " + ((int)(globalVariables.timer)).ToString());
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
