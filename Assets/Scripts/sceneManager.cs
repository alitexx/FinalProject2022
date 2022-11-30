using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{

    public Image blackOutSquare;
    public Animator anim;

    public void endGame()
    {
        // close game
        Application.Quit();
    }
    public void loadLevel(string sceneName)
    {
        Debug.Log("Changing Scenes!");
        StartCoroutine(FadeBlackOutSquare(sceneName));
    }




    public IEnumerator FadeBlackOutSquare(string beginLevel = "")
    {
        if (Time.deltaTime == 0f)
        {
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.Locked;
        }
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => blackOutSquare.color.a == 1);
        Debug.Log(beginLevel);
        SceneManager.LoadScene(beginLevel);
    }
}
