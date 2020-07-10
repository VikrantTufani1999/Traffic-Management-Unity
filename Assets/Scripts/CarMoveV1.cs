using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class CarMoveV1 : MonoBehaviour
{
    public PathCreator MyPathCreator3;
    public float movementSpeed3;
    float movement3 = 0f;

    [SerializeField] GameObject carV1Car;

    public EndOfPathInstruction endPoint3;

    GameController game3;
    ScoreManager link3;

    private void Start()
    {
        game3 = FindObjectOfType<GameController>();
        link3 = FindObjectOfType<ScoreManager>();
    }

    private void Update()
    {
        movement3 += movementSpeed3 * Time.deltaTime;
        transform.position = MyPathCreator3.path.GetPointAtDistance(movement3, endPoint3);
        transform.rotation = MyPathCreator3.path.GetRotationAtDistance(movement3, endPoint3);

        if (game3.stopCubeV1.active == false && movementSpeed3 == 0)
            movementSpeed3 = 10;

        if (transform.position.z < -8.8)
        {
            link3.score += 10;
            Destroy(gameObject);
        }
    }

        private void OnCollisionEnter(Collision collision3)
        {
            /*if (collision.gameObject.tag == "stop")
            {
                movementSpeed3 = 0;
            }*/

            if (collision3.gameObject.tag == "stop2")
            {
                movementSpeed3 = 0;
            }

            else if (collision3.gameObject.tag == "player2")
            {
                movementSpeed3 = 0;
            }


            /*if (collision.gameObject.tag == "black")
            {
                link.score -= 5;
                Destroy(gameObject);
            }*/
        }
    }


