using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title_Camera : MonoBehaviour
{
    float x, y;

    private void confineMouse()
    {
        //just to give it more time, may help by a *little* bit
        Cursor.lockState = CursorLockMode.Confined;
    }
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        confineMouse();
    }
    
    private void Update()
    {
        x = -Input.GetAxis("Mouse Y");
        y = Input.GetAxis("Mouse X");

        //Debug.Log(x);
        if (transform.eulerAngles.x < 1) // make larger
        {
            x = 0.05f;
        }
        else if (transform.eulerAngles.x > 40) // make smaller
        {
            x = -0.05f;
        }
        if (transform.eulerAngles.y < 60) //make larger
        {
            y = 0.05f;
            //old code
            //transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), 0.05f, 0);
        }
        else if ((transform.eulerAngles.y > 120)) // make smaller
        {
            y = -0.05f;
            //old code
            //transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), -0.05f, 0);
        }

        transform.eulerAngles += new Vector3(x/4, y/4, 0);

    }
}