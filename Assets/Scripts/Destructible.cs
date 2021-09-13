using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    //The destructible knows how to take damage and "die"
    public int maximumHitPoints = 3;

    private int currentHitPoints;

    public int GetCurrentHitPoints()
    {
        return currentHitPoints;
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHitPoints = maximumHitPoints;
    }

    //This function gets called by other scripts when its time to take damage
    public void TakeDamage(int damageAmount)
    {
        ModifyHitPoints(-damageAmount);
    }

    //We can do the same thing, but positive, to heal us
    public void HealDamage(int healAmount)
    {
        ModifyHitPoints(healAmount);
    }

    //This function adds or subtracts health
    private void ModifyHitPoints( int modAmount )
    {
        currentHitPoints += modAmount;

        if( currentHitPoints > maximumHitPoints )
        {
            currentHitPoints = maximumHitPoints;
        }

        if( currentHitPoints <= 0 )
        {
            Die();
        }
    }

    //This function is called when our health is 0
    private void Die()
    {
        //Could add animation here!
        Destroy(gameObject);
    }
}
