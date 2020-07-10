using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class L3BlackCar2: MonoBehaviour
{
    public PathCreator MyPathCreator4;
    public float movementSpeed4;
    float movement4;

    [SerializeField] GameObject blackCar2;

    public EndOfPathInstruction endPoint4;

    //bool isRunning2 = false;

    private void Update()
    {
        movement4 += movementSpeed4 * Time.deltaTime;
        transform.position = MyPathCreator4.path.GetPointAtDistance(movement4, endPoint4);
        transform.rotation = MyPathCreator4.path.GetRotationAtDistance(movement4, endPoint4);
        /*if (transform.position.z < -9)
            Destroy(blackCar2);*/

        if (transform.position.x < -17)
            Destroy(blackCar2);
    }

    /*void Stop_Black()
    {
        if(isRunning2 == false)
        {
            movementSpeed2 = 0.0f;
            isRunning2 = true;
        }

        else if(isRunning2 == true)
        {
            movementSpeed2 = 10.0f;
            isRunning2 = false;
        }
    }*/

}
