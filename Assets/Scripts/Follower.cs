using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    //The thing we want to follow
    public Transform followedTransform;

    // Update is called once per frame
    void Update()
    {
        //Set our position equal to the position of the player
        if (followedTransform != null)
        {
            Vector3 newPosition = followedTransform.position;
            newPosition.z = transform.position.z;

            //Set our position equal to the new position
            transform.position = newPosition;
        }
    }
}
