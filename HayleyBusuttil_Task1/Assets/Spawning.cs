using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    //Global variables - variable declaration
    //public - its accessible to all scripts
    public GameObject BallPrefab;
    public static int NumOfBalls = 0; 

    // Start is called before the first frame update (onload)
    void Start()
    {
   
    }

    // Update is called once per frame (infinite loop )
    void Update()
    {
        //to  check the counter of how much balls are spawned
        print(NumOfBalls);

        //When the count is less then 5 - spawn the ball
        if (NumOfBalls < 5)
        {
            if (Input.GetMouseButtonDown(0)) //0 - left mouse click , 1 - right mouse click, 2 - scroll being clicked
            {
                //getting the mouse position , Vector3 - datatype(tuple)
                Vector3 mousePosition = Input.mousePosition;

                //covert from screen space to  world space
                Vector3 inWorldSpace = Camera.main.ScreenToWorldPoint(mousePosition);

                //so that the ball is visable between the background and the camera
                inWorldSpace.z = 0;

                //spawn a ball for every click using the prefab
                Instantiate(BallPrefab, inWorldSpace, Quaternion.identity);

                //Add one to the ball each time a ball is spawned
                NumOfBalls++;
            }
        }
        
    }
}
