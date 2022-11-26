using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class beginTimer : MonoBehaviour
{
    void Update()
    {
        // very basic obv
        globalVariables.timer += Time.deltaTime;
    }
}
