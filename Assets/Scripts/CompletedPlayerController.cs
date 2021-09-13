using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletedPlayerController : MonoBehaviour
{
    public Mover mover;
    public Jumper jumper;
    public SpriteRenderer spriteRenderer;
    public AudioSource audioSource;

    // Update is called once per frame, around 60 times a second
    void Update()
    {
        //Listen for key presses and move left
        if( Input.GetKey( KeyCode.LeftArrow ) || Input.GetKey(KeyCode.A))
        {
            mover.AccelerateInDirection(new Vector2(-1, 0));
            spriteRenderer.flipX = true;
        }

        //Listen for key presses and move right
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            mover.AccelerateInDirection(new Vector2(1, 0));
            spriteRenderer.flipX = false;
        }

        //Listen for key presses and jump
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            jumper.Jump();

            //Play a Jump Sound
            if(audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
}
