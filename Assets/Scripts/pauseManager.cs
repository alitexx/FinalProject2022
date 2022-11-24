using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseManager : MonoBehaviour
{
    [SerializeField] Camera cam2;
    [SerializeField] GameObject player;
    [SerializeField] Canvas pauseMenu;

    void Start()
    {
        cam2.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            player.SetActive(!player.activeInHierarchy);
            cam2.enabled = !cam2.enabled;
            pauseMenu.enabled = !pauseMenu.enabled;
            if (pauseMenu.enabled == true)
            {
                Cursor.lockState = CursorLockMode.None;
            } else
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
            
        }
    }
}
