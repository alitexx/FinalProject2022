using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class globalVariables : MonoBehaviour
{
    // used to track the number of items the player has
    public static int itemsCollected = 0;

    // how much time the player has left
    public static float timer = 0;

    public static string[] itemsToCollect; // new string[] { "Greg", "Kate", "Adam", "Mia" };

}