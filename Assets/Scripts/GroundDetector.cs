using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    //This tells us whether we are currently touching the ground
    [HideInInspector]
    public bool onGround = false;

    //If we are touching ANYTHING, we are considered "on the ground"
    public void OnCollisionStay2D(Collision2D collision)
    {
        onGround = true;
    }

    //Whenever we STOP touching something, we are no longer considered "on the ground"
    public void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;
    }


}
