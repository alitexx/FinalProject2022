using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        var itemsDict = new Dictionary<int, string>() // holds the key and the item 
        {
            { 1, "Item1" }, // change name according to whatever the item is
            { 2, "Item2" },
            { 3, "Item3" }
        };

        // do a random number generation at some point, not right now tho

}

    // Update is called once per frame
    void Update()
    {
        
    }
}
