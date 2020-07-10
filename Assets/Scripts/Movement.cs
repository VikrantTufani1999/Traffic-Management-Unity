using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Movement : MonoBehaviour
{
    [SerializeField] PathCreator MyPathCreator;
    public float movementSpeed;
    float movement = 0f;

    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject Stopper;

    public EndOfPathInstruction endPoint;
   
    GameController game;

    ScoreManager link;

    private void Start()
    {
        Stopper = FindObjectOfType<GameObject>();
        game = FindObjectOfType<GameController>();
        link = FindObjectOfType<ScoreManager>();
    }

    private void Update()
    {
            movement += movementSpeed * Time.deltaTime;
            transform.position = MyPathCreator.path.GetPointAtDistance(movement, endPoint);
            transform.rotation = MyPathCreator.path.GetRotationAtDistance(movement, endPoint);

            if (!game.stopCube.activeInHierarchy && movementSpeed == 0)
                movementSpeed = 10;

            if (transform.position.x > 14)
            {
            link.score += 10; 
            Destroy(gameObject);
            }

            if(transform.position.z <-6)
            {
            link.score += 10;
            Destroy(gameObject);
            }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "stop")
        {
            movementSpeed = 0;
        }

        else if (collision.gameObject.tag == "Player")
        {
            movementSpeed = 0;
        }

        if (collision.gameObject.tag == "black")
        {
            link.score -= 5;
            Destroy(gameObject);
        }
    }
}
