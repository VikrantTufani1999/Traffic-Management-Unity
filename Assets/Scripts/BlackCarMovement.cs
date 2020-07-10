using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class BlackCarMovement : MonoBehaviour
{
    public PathCreator MyPathCreator2;
    public float movementSpeed2;
    float movement2;

    [SerializeField] GameObject blackCar;

    public EndOfPathInstruction endPoint2;

    //bool isRunning2 = false;

    private void Update()
    {
        movement2 += movementSpeed2 * Time.deltaTime;
        transform.position = MyPathCreator2.path.GetPointAtDistance(movement2, endPoint2);
        transform.rotation = MyPathCreator2.path.GetRotationAtDistance(movement2, endPoint2);
        if(transform.position.z < -9)
        Destroy(blackCar);

        if (transform.position.x > 17)
            Destroy(blackCar);
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
