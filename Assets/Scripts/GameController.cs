using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] bool redLight = true;
    [SerializeField] bool redLight2 = true;
    public GameObject stopCube;
    public GameObject stopCubeV1;

    Movement move;
    CarMoveV1 speedControl;

    // Start is called before the first frame update
    void Start()
    {
        move = FindObjectOfType<Movement>();
        speedControl = FindObjectOfType<CarMoveV1>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stopCube.active == false && move.movementSpeed == 0)
            move.movementSpeed = 10;

        NewCarV1Move();

    }

    private void NewCarV1Move()
    {
        if (!stopCubeV1.activeInHierarchy && speedControl.movementSpeed3 == 0)
            speedControl.movementSpeed3 = 10;
    }

    public void OnStopButtobClicked()
    {
        redLight = !redLight; //toggle;

        if(!redLight)
        {
            stopCube.SetActive(false);
        }
        else
        {
            stopCube.SetActive(true);
        }
    }

    public void OnStopButtonClicked2()
    {
        redLight2 = !redLight2; //toggle;

        if (!redLight2)
        {
            stopCubeV1.SetActive(false);
        }
        else
        {
            stopCubeV1.SetActive(true);
        }
    }


}
