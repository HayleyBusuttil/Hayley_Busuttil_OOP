using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Movingbox : MonoBehaviour
{
    float xMin, xMax, yMin,yMax;
    // Start is called before the first frame update
    void Start()
    {
        //to get te boundaries
        Vector3 topLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
        Vector3 topRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
        Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 bottomRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));

        xMin = topLeft.x + 0.5f;// or bottom left as long as you use the left 
        xMax = topRight.x - 0.5f;// or top left as long as you use the left 
        yMin = bottomLeft.y + 0.5f;// or bottom right as long as you use the right
        yMax = topLeft.y - 0.5f;// or top right as long as you use the right
    }

    // Update is called once per frame
    void Update()
    {
        //Keyboard inputs
        if (Input.GetKeyDown(KeyCode.RightArrow)) //&& (this.transform.position.x < xMax)) you can use this method too
        {
            float newXPosition = Mathf.Clamp(this.transform.position.x + 1, xMin, xMax); //clamp is used to keep a postion in a certain range
            print("right");
            this.transform.position = new Vector3(newXPosition,
                                                  this.transform.position.y,
                                                  this.transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            float newXPosition = Mathf.Clamp(this.transform.position.x - 1, xMin, xMax);
            print("left");
            this.transform.position = new Vector3(newXPosition,
                                                  this.transform.position.y,
                                                  this.transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            float newYPosition = Mathf.Clamp(this.transform.position.y + 1, yMin, yMax);
            print("up");
            this.transform.position = new Vector3(this.transform.position.x,
                                                  newYPosition,
                                                  this.transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            float newYPosition = Mathf.Clamp(this.transform.position.y - 1, yMin, yMax);

            print("down");
            this.transform.position = new Vector3(this.transform.position.x,
                                                  newYPosition,
                                                  this.transform.position.z);
        }

    }
}
