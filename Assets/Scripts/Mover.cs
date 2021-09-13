using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Mover : MonoBehaviour
{
    //Set some public variables so we can control our speed
    public float acceleration = 10f;
    public float maximumSpeed = 15f;

    private Rigidbody2D myRigidbody2D;

    // Start is called before the first frame update
    void Awake()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void AccelerateInDirection( Vector2 direction )
    {
        //Normalize just means... set between 0 and 1 so that it only represents direction
        direction = Vector3.Normalize(direction);

        //Make our velocity faster depending on acceleration and frame rate
        Vector2 newVelocity = myRigidbody2D.velocity +
            (direction * acceleration * Time.deltaTime);

        //Set maximum speeds in both directions
        newVelocity.x = Mathf.Clamp(newVelocity.x, -maximumSpeed, maximumSpeed);
        newVelocity.y = Mathf.Clamp(newVelocity.y, -maximumSpeed, maximumSpeed);

        myRigidbody2D.velocity = newVelocity;
    }
}
