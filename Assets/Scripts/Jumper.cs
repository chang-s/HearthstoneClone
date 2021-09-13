using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    //Our jump force is how high we can actually jump
    public float jumpForce = 6f;

    //In this script, the other scripts it needs are grabbed automatically. So we can make them private
    //Private variables are not visible in the inspector, but they still exist
    private Rigidbody2D myRigidBody2D;
    private GroundDetector groundDetector;

    void Start()
    {
        //This script needs a rigidbody2d and a ground detector attached to the same object to work
        myRigidBody2D = GetComponent<Rigidbody2D>();
        groundDetector = GetComponent<GroundDetector>();
    }

    public void Jump()
    {
        //As long as we are on the ground
        if (groundDetector == null || groundDetector.onGround == true)
        {
            //Jump!
            myRigidBody2D.velocity += new Vector2(0f, jumpForce);

            //If I'm jumping too fast, slow me down
            if (myRigidBody2D.velocity.y > jumpForce)
            {
                myRigidBody2D.velocity = new Vector2(myRigidBody2D.velocity.x, jumpForce);
            }
        }
    }
}
