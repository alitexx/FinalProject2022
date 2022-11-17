using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title_Camera : MonoBehaviour
{
    public float speed = 1;
    private bool canMove;



    /// <summary>
    /// this code is very much NOT WORKING!!
    /// i need to think of a better way to use it and go from there, it'll prolly be done by the end of today!
    /// </summary>
    private void Update()
    {
        canMove = true;
        if (transform.eulerAngles.x < -40)
        {
            canMove = false;
            if (transform.eulerAngles.y < 55)
            {
                transform.eulerAngles += new Vector3(0.1f, 0.1f, 0);
            } else if ((transform.eulerAngles.y > 130))
            {
                transform.eulerAngles += new Vector3(0.1f, -0.1f, 0);
            } else
            {
                // only x is at the edge
                
                transform.eulerAngles += new Vector3(0.1f, Input.GetAxis("Mouse X"), 0);
            }
        } else if ((transform.eulerAngles.x > 40))
        {
            canMove = false;
            if (transform.eulerAngles.y < 55)
            {
                transform.eulerAngles += new Vector3(-0.1f, 0.1f, 0);
            }
            else if ((transform.eulerAngles.y > 130))
            {
                transform.eulerAngles += new Vector3(-0.1f, -0.1f, 0);
            }
            else
            {
                // only x is at the edge
                Debug.Log("going UUUUUUUUUUUUUUUUUUPPPPPPP!!!!!!!!!!!!!");
                transform.eulerAngles += new Vector3(-0.1f, Input.GetAxis("Mouse X"), 0);
            }
        }
        //only y is at the limit
        else if (transform.eulerAngles.y < 55)
        {
            canMove = false;
            transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), 0.1f, 0);
        }
        else if ((transform.eulerAngles.y > 130))
        {
            canMove = false;
            transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), -0.1f, 0);
        } 
        
        
        
        if (canMove == true)
        {
            transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
        }

    }
}