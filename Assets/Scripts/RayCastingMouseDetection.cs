using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastingMouseDetection : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit) && (hit.collider.GetComponent<cakeslice.Outline>() != null))
        {
            //checks if it has an outline script, if it does, turn the outline on.
            // find a way to turn it off (im still thinking abt it) when the mouse moves off the item
            (hit.collider.GetComponent<cakeslice.Outline>().eraseRenderer) = false;
        }
    }
}