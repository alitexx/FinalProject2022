using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title_Camera : MonoBehaviour
{
    public float speed = 1;
    float x, y;
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
            //transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), 0.05f, 0);
        }
        else if ((transform.eulerAngles.y > 130)) // make smaller
        {
            y = -0.05f;
            //transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), -0.05f, 0);
        } 
        
        transform.eulerAngles += new Vector3(x, y, 0);

    }
}
//old code
//if (transform.eulerAngles.y < 55)
//{
//    y = 0.05f;
//    //transform.eulerAngles += new Vector3(0.05f, 0.05f, 0);
//} else if ((transform.eulerAngles.y > 130))
//{
//    y = -0.05f;
//    //transform.eulerAngles += new Vector3(0.05f, -0.05f, 0);
//} else
//{
//    // only x is at the edge

//    //transform.eulerAngles += new Vector3(0.05f, Input.GetAxis("Mouse X"), 0);
//}
//    if (transform.eulerAngles.y < 55)
//    {
//        transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), 0.05f, 0);
//    }
//    else if ((transform.eulerAngles.y > 130))
//    {
//        transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), -0.05f, 0);
//    }
//    else
//    {
//        //transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
//    }
//}
//only y is at the limit