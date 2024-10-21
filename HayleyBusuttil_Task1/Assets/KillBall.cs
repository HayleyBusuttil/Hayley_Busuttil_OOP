using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //When the right mouse click is clicked you will delete a ball
        if (Input.GetMouseButtonDown(1)) //0 - left mouse click , 1 - right mouse click, 2 - scroll being clicked
        {
            //getting the mouse position , Vector3 - datatype(tuple)
            Vector3 mousePosition = Input.mousePosition;

            //covert from screen space to  world space
            Vector3 inWorldSpace = Camera.main.ScreenToWorldPoint(mousePosition);

            //so that the ball is visable between the background and the camera
            inWorldSpace.z = 0;

            //check if the ball is close enough to the right click 
            float distance = Vector3.Distance(inWorldSpace, this.gameObject.transform.position);

            //to remove the ball closest to the click
            if(distance < 0.5)
            {
                //destorying the ball
                Destroy(this.gameObject);
                //Since it is in another script you have to call the script first then the variable name 
                //You will decrease the counter with every destoryed ball
                Spawning.NumOfBalls--;
            }

        }
    }
}
