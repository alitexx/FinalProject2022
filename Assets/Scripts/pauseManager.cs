using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pauseManager : MonoBehaviour
{
    [SerializeField] Camera cam2;
    [SerializeField] GameObject player;
    [SerializeField] Canvas pauseMenu;
    [SerializeField] TextMeshProUGUI levelHS, currentTime, levelHSBG, currentTimeBG;

    void Start()
    {
        cam2.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            togglePause();
        }
    }
    public void togglePause()
    {
        player.SetActive(!player.activeInHierarchy);
        cam2.enabled = !cam2.enabled;
        pauseMenu.enabled = !pauseMenu.enabled;
        if (pauseMenu.enabled == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            levelHS.text = ("Fastest Time on this level: " + ((int)(globalVariables.bestTimeLevel1)).ToString());
            currentTime.text = ("Current Time: " + ((int)(globalVariables.timer)).ToString());
            levelHSBG.text = ("Fastest Time on this level: " + ((int)(globalVariables.bestTimeLevel1)).ToString());
            currentTimeBG.text = ("Current Time: " + ((int)(globalVariables.timer)).ToString());
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
        }
    }
}
