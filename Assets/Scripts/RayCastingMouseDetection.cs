using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastingMouseDetection : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    string pastHit = "IAMASTRING";


    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            //Debug.Log(pastHit.Substring(0, 4));
            if (((string)hit.collider.name).Substring(0, 4) == "ITEM"){ // if it hits an item
                (hit.collider.GetComponent<Outline>().OutlineWidth) = 5f;

            } 
            // if the last item was an item, and the current item is not an item
            else if ((pastHit != hit.collider.name) && (pastHit.Substring(0, 4) == "ITEM"))
            {
                //Debug.Log(GameObject.Find(pastHit));
                (GameObject.Find(pastHit).GetComponent<Outline>().OutlineWidth) = 0f;
            }
            pastHit = hit.collider.name;
        }
    }
}