using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour
{
    //How much damage we will do every time we touch a Destructible
    public int damage = 1;

    //If we touch something...
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destructible destructible = collision.gameObject.GetComponent<Destructible>();

        if( destructible != null )
        {
            //Deal damage to the Destructible we touched!
            destructible.TakeDamage(damage);
        }
    }
}
