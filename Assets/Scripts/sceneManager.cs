using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public GameObject blackOutSquare;
    private bool debounce = true;
    private void Start()
    {
        StartCoroutine(FadeBlackOutSquare("", false)); // to fade out
    }

    public void endGame()
    {
        // close game
        Application.Quit();
    }
    public void loadLevel(string sceneName)
    {
        if (debounce == true) // was firing multiple times
        {
            debounce = false;
            StartCoroutine(FadeBlackOutSquare(sceneName)); // to fade in
            debounce = true;
        }
    }

    public IEnumerator FadeBlackOutSquare(string beginLevel = "", bool fadeToBlack = true, int fadeSpeed = 5)
    {
        Color objectColor = blackOutSquare.GetComponent<Image>().color;
        float fadeAmount;
        if (Time.deltaTime == 0f)
        {
            Time.timeScale = 0.1f;
            fadeSpeed = 50;
        }

        // an if statement in here that checks if the player is entering the game itself,
        // if so then change the level txt accordingly

        if (fadeToBlack)
        {
            while (blackOutSquare.GetComponent<Image>().color.a < 1)
            {

                fadeAmount = objectColor.a + (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }

            while (blackOutSquare.GetComponent<Image>().color.a >= 1)
            {
                SceneManager.LoadScene(beginLevel);
                Time.timeScale = 1f;
                break;
            }
        }
        else
        {
            while (blackOutSquare.GetComponent<Image>().color.a > 0)
            {
                fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

                objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
                blackOutSquare.GetComponent<Image>().color = objectColor;
                yield return null;
            }
        }
    }
}
