using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title_Camera : MonoBehaviour
{
    public float speed = 1;
    float x, y;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.Confined;
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
        if (transform.eulerAngles.y < 55) //make larger
        {
            y = 0.05f;
            //old code
            //transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), 0.05f, 0);
        }
        else if ((transform.eulerAngles.y > 130)) // make smaller
        {
            y = -0.05f;
            //old code
            //transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), -0.05f, 0);
        }

        transform.eulerAngles += new Vector3(x/3, y/3, 0);

    }
}